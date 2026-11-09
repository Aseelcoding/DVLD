using PL.Forms;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class frmMain : Form
    {
        private bool _IsManagePeopleScreenOpen;
        public frmMain()
        {
            InitializeComponent();
            _IsManagePeopleScreenOpen = false;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {

            frmManagePeople ManagePeopleForm = new frmManagePeople();
            if (_IsManagePeopleScreenOpen)
                return;

            _IsManagePeopleScreenOpen = true;
            ManagePeopleForm.Show();

            ManagePeopleForm.Closed += (s, args) =>
            {
                _IsManagePeopleScreenOpen = false;
            };

           
        }
    }
}
