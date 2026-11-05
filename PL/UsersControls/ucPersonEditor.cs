using BLL;
using PL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.UsersControls
{
    public partial class ucPersonEditor : UserControl
    {
        private DataTable _dtCountries;
        private enum eCurrentPhoto { DefaultMale, DefaultFemale, CustomPhoto }
        eCurrentPhoto CurrentPhoto;
        public ucPersonEditor()
        {
            InitializeComponent();
            defaultValues();
        }
        private void SetDefaultPicture()
        {
            switch (CurrentPhoto)
            {
                case eCurrentPhoto.DefaultMale:
                    picPerson.Image = Properties.Resources.default_Male;
                    break;
                case eCurrentPhoto.DefaultFemale:
                    picPerson.Image = Properties.Resources.default_Female;
                    break;
            }
        }
        private void defaultValues()
        {
            dateBirthOfDate.MinDate = DateTime.Now.AddYears(-120);
            dateBirthOfDate.MaxDate = DateTime.Now.AddYears(-18);
            dateBirthOfDate.Value = dateBirthOfDate.MaxDate;
            if (radbtnMale.Checked)
            { picPerson.Image = Properties.Resources.default_Male; CurrentPhoto = eCurrentPhoto.DefaultMale; }
            else
            { picPerson.Image = Properties.Resources.default_Female; CurrentPhoto = eCurrentPhoto.DefaultFemale; }


        }
        public string Title
        {

            set { labTitle.Text = value; }
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

            cmbCountry.SelectedIndex = 190;


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
            SetDefaultPicture();
        }

        private void radbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            CurrentPhoto = eCurrentPhoto.DefaultFemale;
            SetDefaultPicture();

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&e.KeyChar != ' ' &&e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


    }
    }

