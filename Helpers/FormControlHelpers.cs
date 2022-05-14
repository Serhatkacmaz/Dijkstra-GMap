using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMap_Tutorial.Helpers
{
    public static class FormControlHelpers
    {
        public static void ClearInputs(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = String.Empty;
                }
            }
        }
    }
}
