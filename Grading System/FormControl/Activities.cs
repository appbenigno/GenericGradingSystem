﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class Activities
    {
        public static void Modify(ListView targetListLeft, ListView targetListRight, Button add, Button remove, TextBox weightTextBox)
        {
            try
            {
                targetListLeft.Enabled = false;
                targetListRight.Enabled = false;
                add.Enabled = false;
                remove.Enabled = false;
                weightTextBox.Enabled = true;
                weightTextBox.Focus();
                weightTextBox.Select(0, weightTextBox.TextLength);
            }
            catch { }
        }
        public static void ModifyConfirm(ListView targetListLeft, ListView targetListRight, Button add, Button remove, TextBox weightTextBox)
        {
            try
            {
                weightTextBox.Enabled = false;
                targetListRight.Enabled = true;
                targetListRight.SelectedItems[0].Selected = false;
                targetListLeft.Enabled = true;
                add.Enabled = true;
                remove.Enabled = true;
            }
            catch { }
        }
    }
}
