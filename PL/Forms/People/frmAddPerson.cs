using PL.UsersControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Forms.People
{
    public partial class frmAddPerson : Form
    {
        public frmAddPerson()
        {
            InitializeComponent();
            ucPersonAdd.Title = "Add New Person";
            ucPersonAdd.UcClosed += UcPersonAdd_UcClosed;
        }

        private void UcPersonAdd_UcClosed(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
