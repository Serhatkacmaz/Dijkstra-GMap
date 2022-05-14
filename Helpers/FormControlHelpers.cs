using System;
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

        public static bool IsNullOrEmptyInputs(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
