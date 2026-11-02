using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Helpers
{
    public class UIHelper
    {

        public static void CenterHorizontally(Control control)
        {
            if (control == null || control.Parent == null)
                return;

            control.Left = (control.Parent.ClientSize.Width - control.Width) / 2;
        }
    }
}
