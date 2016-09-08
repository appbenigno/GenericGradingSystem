using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class Cancel
    {
        public static void EditStudent(TextBox familyName, TextBox givenName, TextBox middleInitial, Button update, Button cancel, Button add ,Button delete, ListView targetList)
        {
            familyName.Enabled = false;
            givenName.Enabled = false;
            middleInitial.Enabled = false;
            update.Enabled = false;
            cancel.Enabled = false;
            add.Enabled = true;
            delete.Enabled = false;
            targetList.Enabled = true;
            targetList.SelectedItems[0].Selected = false;
        }
    }
}
