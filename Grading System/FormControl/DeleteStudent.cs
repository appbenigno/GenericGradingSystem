using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class DeleteStudent
    {
        public static void Confirm(TextBox section, TextBox familyName, TextBox givenName,TextBox middleInitial, Button update, Button cancel, Button delete, ListView targetList)
        {
            familyName.Enabled = false;
            givenName.Enabled = false;
            middleInitial.Enabled = false;
            update.Enabled = false;
            cancel.Enabled = false;
            delete.Enabled = false;
            targetList.Enabled = true;
        }
    }
}
