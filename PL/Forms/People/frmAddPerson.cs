using Entities;
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
            ucPersonAdd.Mode = Enums.PersonEditorMode.Add;
            ucPersonAdd.UcClosed += ucPersonAdd_UcClosed;
            ucPersonAdd.SavePerson += SavePerson;
        }

        
        private void ucPersonAdd_UcClosed(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SavePerson(Person person)
        {
            // Handle the saved person object here
           

          
        }

    }
}
