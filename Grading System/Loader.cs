using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Winforms.Builder.Show();
                Winforms.Loader.Hide();
            }
        }

        private void imgGenerateHtml_MouseHover(object sender, EventArgs e)
        {
            imgGenerateHtml.Image = ProjResource.button_generatehtml_hover;
        }

        private void imgGenerateHtml_MouseLeave(object sender, EventArgs e)
        {
            imgGenerateHtml.Image = ProjResource.button_generatehtml;
        }

        private void imgGenerateHtml_Click(object sender, EventArgs e)
        {
            if (flags.isRaised("selectedtemplate"))
            {
                saveHTML.InitialDirectory = Path.GetFullPath(".\\") + FormControl.HTML.FileStructure.htmlPath;
                saveHTML.ShowDialog();
                FormControl.HTML.Write(Globals.Theme.selected, Globals.Builder.Activities, Globals.Builder.Entries, saveHTML, notifyIcon);
            }
            else
            {
                MessageBox.Show("Select a template first.", "No selected template");
            }
        }

        private void Loader_Activated(object sender, EventArgs e)
        {
            lblName.Text = Globals.Report.Name;
            lblSection.Text = Globals.Report.Section;
            lblPeriod.Text = Globals.Report.Period;
            lblGPA.Text = Globals.Report.Gpa;
            lblGWA.Text = Globals.Report.Gwa.ToString();
            lblRemarks.Text = Globals.Report.Remarks;
        }

        private void Loader_Load(object sender, EventArgs e)
        {

        }
    }
}
