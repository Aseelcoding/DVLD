using PL.Forms.People;
using PL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Forms
{
    public partial class frmManagePeople : Form
    {

        DataTable dtPeople;
        public frmManagePeople()
        { 
            InitializeComponent();
            RefreshData();
        }
        private void RefreshData(string Filter="") 
        {
            LoadData();
            DataView dvPeople= dtPeople.DefaultView;

            dvPeople.RowFilter = Filter;

            foreach(DataRowView row in dvPeople) 
            {
                dgvPeople.Rows.Add
                    (
                    row["PersonID"],
                    row["NationalNo"],
                    row["FirstName"],
                    row["SecondName"],
                    row["ThirdName"],
                    row["LastName"],
                     row["Gendor"],
                    row["DateOfBirth"],
                      row["CountryName"],
                    row["Phone"],
                    row["Email"]
                  

                    );

               
            }



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
    }
}
