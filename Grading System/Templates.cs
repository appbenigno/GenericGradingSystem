using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSThemes;

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
            GS.getThemes(lstTemplates);
        }

        private void imgContinue_Click(object sender, EventArgs e)
        {
            Winforms.GradeType.Show();
            Winforms.Templates.Hide();
        }

        private void lstTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Template.setTemplate(lstTemplates, Globals.Theme.selected, imgTemplatePreview, statusLabel);
            }
            catch { }
        }

        private void imgOK_MouseMove(object sender, MouseEventArgs e)
        {
            imgOK.Image = ProjResource.button_ok_hover;
        }

        private void imgOK_MouseLeave(object sender, EventArgs e)
        {
            imgOK.Image = ProjResource.button_ok;
        }

        private void imgOK_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text.Equals("-"))
            {
                MessageBox.Show("Select a theme first!", "No selected template", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Winforms.Builder.Show();
                Winforms.Templates.Hide();
            }
        }

        private void Templates_Load(object sender, EventArgs e)
        {
            try
            {
                lstTemplates.SetSelected(0, true);
            }
            catch { }
        }
    }
}