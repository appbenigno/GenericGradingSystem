using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public class GS
    {
        public static void setTheme(ListBox targetListbox)
        {
            try
            {
                GSThemes.List.AllTemplates(targetListbox);
            }
            catch
            {
                MessageBox.Show("Unable to populate themes list. External file library 'GSThemes.dll' is missing or corrupt.\nThe program will load the default theme instead.", "Error Loading Templates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                targetListbox.Items.Clear();
                targetListbox.Items.Add("Simple");
                //test
            }
        }
    }
}
