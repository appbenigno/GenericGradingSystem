using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class Entries
    {
        public static void Edit()
        {

        }
        public static void Confirm()
        {

        }
        public static void Delete()
        {

        }

        public static void Cancel(TextBox description, TextBox score, TextBox maxscore, Button update, Button delete, Button cancel)
        {
            description.Enabled = false;
            score.Enabled = false;
            maxscore.Enabled = false;

        }
    }
}
