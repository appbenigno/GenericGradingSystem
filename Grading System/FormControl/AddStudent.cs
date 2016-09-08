using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class AddStudent
    {
        public static void Confirm(ListView targetList)
        {
            try
            {
                targetList.Items[0].Selected = false;
                int x = targetList.Items.Count - 1;
                targetList.Items[x].Selected = true;
            }
            catch { }
        }
    }
}
