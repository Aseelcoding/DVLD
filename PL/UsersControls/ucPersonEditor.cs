using BLL;
using Entities;
using PL.Enums;
using PL.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace PL.UsersControls
{
    public partial class ucPersonEditor : UserControl
    {
        private DataTable _dtCountries;
        private enum eCurrentPhoto { DefaultMale, DefaultFemale, CustomPhoto }
        eCurrentPhoto CurrentPhoto;
        string CurrentPhotoPath;
        PersonEditorMode _Mode;

        Person _Person=new Person();
        public ucPersonEditor()
        {
            InitializeComponent();
            defaultValues();
          
           

        }
        private void SetPicture()
        {
            switch (CurrentPhoto)
            {
                case eCurrentPhoto.DefaultMale:
                    picPerson.Image = Properties.Resources.default_Male;
                    break;
                case eCurrentPhoto.DefaultFemale:
                    picPerson.Image = Properties.Resources.default_Female;
                    break;
                case eCurrentPhoto.CustomPhoto:
                    if (!string.IsNullOrEmpty(CurrentPhotoPath))
                    {
                        picPerson.Image = Image.FromFile(CurrentPhotoPath);
                    }
                    break;


            }
        }
        private void defaultValues()
        {
            _Person.PersonId = 0;
            dateDateOfBirth.MinDate = DateTime.Now.AddYears(-120);
            dateDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dateDateOfBirth.Value = dateDateOfBirth.MaxDate;
            SetPicture();


        }
        public string Title
        {

            set { labTitle.Text = value; }
        }
        public PersonEditorMode Mode
        {
            get { return _Mode; }
            set { _Mode = value; }
        }
        private void LoadCountries()
        {
            try
            {
                _dtCountries = BLLCountries.GetAllCountries();
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }
        private void LoadCountriesIntoComboBox()
        {
            DataView dvCountries = _dtCountries.DefaultView;


            cmbCountry.DataSource = dvCountries;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";

            try
            {
                cmbCountry.SelectedIndex = 190;

            }
            catch 
            {
                cmbCountry.SelectedIndex = 0;

            }
        }
        private void ucPersonEditor_Load(object sender, EventArgs e)
        {

            LoadCountries();
            LoadCountriesIntoComboBox();
        }

        public event EventHandler UcClosed;

        private void btnClose_Click(object sender, EventArgs e)
        {
            UcClosed?.Invoke(this, EventArgs.Empty);
        }

        private void radbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            CurrentPhoto = eCurrentPhoto.DefaultMale;
            SetPicture();
        }

        private void radbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            CurrentPhoto = eCurrentPhoto.DefaultFemale;
            SetPicture();

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&e.KeyChar != ' ' &&e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SetError(Control control, IEnumerable<ValidationResult> errors)
        {
           

            errorProvider1.SetError(control, string.Join("\n", errors.Select(e => e.ErrorMessage)));

            

        }
        public delegate void PersonSavedEventHandler (Person person);   
        public event PersonSavedEventHandler SavePerson;
        private bool ValidatePerson()
        {
            List<ValidationResult> errors=new List<ValidationResult>(); 

           return Validator.TryValidateObject(_Person, new ValidationContext(_Person),  errors, true);


      
        }
        
        private void LoadDataInPersonObject()
        {
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.DateOfBirth = dateDateOfBirth.Value;
            _Person.Gender = radbtnMale.Checked ? (byte)0 : (byte)1;
            _Person.Address = txtAddress.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.NationalityId = Convert.ToInt32(cmbCountry.SelectedValue);


            if (CurrentPhoto == eCurrentPhoto.CustomPhoto)
                _Person.ImagePath = CurrentPhotoPath;
            else
                _Person.ImagePath = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //here we will save the person object and raise the event
            //before that we need to validate the data entered by the user
            LoadDataInPersonObject();
            if (!ValidatePerson())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            SavePerson?.Invoke(_Person);
        }

        private void LeaveField(object sender,EventArgs e)
        {
            List<ValidationResult> errors= new List<ValidationResult>();
            Control control = (Control)sender;
            control.Text.Trim();

            string propertyName = control.Tag.ToString();
            PropertyInfo property = _Person.GetType().GetProperty(propertyName);
            property.SetValue(_Person, Convert.ChangeType(control.Text, property.PropertyType));
            object propertyValue = property.GetValue(_Person);


            Validator.TryValidateProperty(propertyValue, new ValidationContext(_Person) { MemberName = propertyName }, errors);
            SetError(control, errors);
        }

        private void lbLinkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentPhotoPath = openFileDialog.FileName;
                if(CurrentPhotoPath.Length>500)
                   { MessageBox.Show("Image path cannot exceed 500 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);return;}
                CurrentPhoto = eCurrentPhoto.CustomPhoto;
                lbLinkRemoveImage.Visible = true;

                SetPicture();
            }
           
        }

        private void lbLinkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentPhoto = radbtnMale.Checked ? eCurrentPhoto.DefaultMale : eCurrentPhoto.DefaultFemale;
            SetPicture();
            lbLinkRemoveImage.Visible = false;
        }
    }
    }

