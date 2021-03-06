﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void imgEnter_Click(object sender, EventArgs e)
        {
            Winforms.Templates.Show();
            Winforms.Login.Hide();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
        }

        private void imgContinue_Click(object sender, EventArgs e)
        {
            Winforms.Templates.Show();
            Winforms.Login.Hide();
        }

        private void imgContinue_MouseMove(object sender, MouseEventArgs e)
        {
            imgContinue.Image = ProjResource.button_continue_hover;
        }

        private void imgContinue_MouseLeave(object sender, EventArgs e)
        {
            imgContinue.Image = ProjResource.button_continue;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Winforms.Login.Icon = ProjResource.favicon;
        }
    }
}
