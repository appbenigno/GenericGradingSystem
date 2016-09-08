using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class ModifyStudent
    {
        public static void EditDetails(TextBox familyName, TextBox givenName, TextBox middleInitial, Button update, Button cancel,Button add, Button delete, ListView targetList)
        {
            targetList.Enabled = false;
            familyName.Enabled = true;
            givenName.Enabled = true;
            middleInitial.Enabled = true;
            update.Enabled = true;
            cancel.Enabled = true;
            add.Enabled = false;
            delete.Enabled = true;
        }
        
    }
}
