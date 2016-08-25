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
            Template.setTemplate(lstTemplates, Globals.Theme.selectedTheme, imgTemplatePreview);
            statusLabel.Text = Globals.Theme.selectedTheme.ToString();
        }
    }
}