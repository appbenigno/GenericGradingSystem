using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class Entries
    {
        public static void Edit(TextBox description, TextBox score, TextBox maxscore, Button add, Button update, Button delete, Button cancel, ListView sourceList)
        {
            description.Enabled = true;
            score.Enabled = true;
            maxscore.Enabled = true;
            add.Enabled = false;
            update.Enabled = true;
            delete.Enabled = true;
            cancel.Enabled = true;
            sourceList.Enabled = false;
        }
        public static void Confirm(TextBox description, TextBox score, TextBox maxscore, Button add, Button update, Button delete, Button cancel, ListView sourceList)
        {
            description.Enabled = false;
            score.Enabled = false;
            maxscore.Enabled = false;
            add.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            cancel.Enabled = false;
            sourceList.Enabled = true;
        }
        public static void Delete(TextBox description, TextBox score, TextBox maxscore, Button add, Button update, Button delete, Button cancel, ListView sourceList)
        {
            description.Enabled = false;
            description.Text = "";
            score.Enabled = false;
            score.Text = "";
            maxscore.Enabled = false;
            maxscore.Text = "";
            add.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            cancel.Enabled = false;
            sourceList.Enabled = true;
        }

        public static void Cancel(TextBox description, TextBox score, TextBox maxscore, Button add, Button update, Button delete, Button cancel, ListView sourceList)
        {
            description.Enabled = false;
            score.Enabled = false;
            maxscore.Enabled = false;
            add.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            cancel.Enabled = false;
            sourceList.Enabled = true;
        }
    }
}
