using PL.Forms.People;
using PL.Helpers;
using System;
using System.Data;
using System.Windows.Forms;
using P_utilities;
using P_Exceptions;
namespace PL.Forms
{
    public partial class frmManagePeople : Form
    {

        DataTable dtPeople;
        public frmManagePeople()
        { 
            InitializeComponent();
            RefreshData();
            SetDefaultValues();
        }
        
        private string BuildFilter(string FilterValue)
        {
            if(FilterValue==""|| FilterValue==null)
            {
               return string.Empty;
            }

            switch(cmbFilter.SelectedIndex)
            {

                case 1:
                   {
                        int PID = -1;
                        int.TryParse(FilterValue, out PID);
                        return $"PersonID = {PID}"; 
                   }

                case 2: // National No
                    return $"NationalNo LIKE '%{FilterValue}%'";
                case 3: // First Name
                    return $"FirstName LIKE '%{FilterValue}%'";
                case 4: // Second Name
                    return $"SecondName LIKE '%{FilterValue}%'";
                case 5: // Third Name
                    return $"ThirdName LIKE '%{FilterValue}%'";
                case 6: // Last Name
                    return $"LastName LIKE '%{FilterValue}%'";
                case 7: // Nationality
                        return $"CountryName LIKE '%{FilterValue}%'";
                case 8: //Gender
                    {
                        if(FilterValue == "Male")
                        {
                            return $"Gender = 0";
                        }
                        else if (FilterValue == "Female")
                        {
                            return $"Gender = 1";
                        }
                        else
                        {
                            return string.Empty;
                        }
                      
                    }

                case 9: // Phone
                    return $"Phone LIKE '%{FilterValue}%'";
                case 10: // Email
                    return $"Email LIKE '%{FilterValue}%'";
                default:
                    return string.Empty;
            }
        }

        private void RefreshData(string Filter="") 
        {
            LoadData();

            DataView dvPeople= dtPeople.DefaultView;

            dvPeople.RowFilter = BuildFilter(Filter);

            dgvPeople.Rows.Clear();
            foreach (DataRowView row in dvPeople) 
            {
                dgvPeople.Rows.Add
                    (
                    row["PersonID"],
                    row["NationalNo"],
                    row["FirstName"],
                    row["SecondName"],
                    row["ThirdName"],
                    row["LastName"],
                     DisplayHelper.GetGenderDisplayValue(Convert.ToInt32(row["Gender"])),
                    row["DateOfBirth"],
                      row["CountryName"],
                    row["Phone"],
                    row["Email"]
                  

                    );

               
            }

            SetRecordsValue();

        }
        private void LoadData() 
        {
            try
            {
                dtPeople = BLL.BLLPeople.GetAllPeople();
            }
            catch(Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }
        public event EventHandler FormClosed;
        private void btnClose_Click(object sender, EventArgs e)
        {

            FormClosed?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson();
            frmAddPerson.ShowDialog();

        }
        private void SetRecordsValue()
        {
            lbRecords.Text = $"{dgvPeople.Rows.Count}";
        }
        private void SetDefaultValues()
        {
            cmbFilter.SelectedIndex = 0;

        }
        private void txtBarSearch_TextChanged(object sender, EventArgs e)
        {
            string txtFilter = utilities.ClearFilterString(txtBarSearch.Text);
            RefreshData(txtFilter);

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBarSearch.Visible = cmbFilter.SelectedIndex != 0;
        }
    }
}
