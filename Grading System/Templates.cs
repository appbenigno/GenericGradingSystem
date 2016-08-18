using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public partial class Templates : Form
    {
        public Templates()
        {
            InitializeComponent();
        }

        private void Templates_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Winforms.Login.Show();
                Winforms.Templates.Hide();
            }
        }

        private void Templates_Activated(object sender, EventArgs e)
        {
            GS.setTheme(lstTemplates);
            statusLabel.Text = "";
        }

        private void imgContinue_Click(object sender, EventArgs e)
        {
            Winforms.GradeType.Show();
            Winforms.Templates.Hide();
        }

        private void lstTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusLabel.Text = lstTemplates.SelectedItem.ToString();
            Globals.Theme.selected = lstTemplates.SelectedItem.ToString();
        }
    }
}
