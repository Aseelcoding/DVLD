using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Helpers;

namespace PL.Forms
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        { 
            InitializeComponent();
        }

        public event EventHandler FormClosed;

      
        private void btnClose_Click(object sender, EventArgs e)
        {

            FormClosed?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
