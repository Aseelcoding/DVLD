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
        DataTable dtCountries;
        public ucPersonEditor()
        {
            InitializeComponent();

            dateBirthOfDate.MinDate = DateTime.Now.AddYears(-18);
            dateBirthOfDate.MaxDate=DateTime.Now.AddYears(120);
            dateBirthOfDate.Value = dateBirthOfDate.MinDate;
            
        }

        public string Title
        {
           
            set { labTitle.Text = value; }
        }

        private void LoadCountries() 
        {
            try
            {
                dtCountries = BLLCountries.GetAllCountries();
            }
            catch(Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }
        private void LoadCountriesIntoComboBox()
        {
            DataView dvCountries = dtCountries.DefaultView;

           
                cmbCountry.DataSource = dvCountries;
                cmbCountry.DisplayMember= "CountryName";
            cmbCountry.ValueMember= "CountryID";    


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
    }
}
