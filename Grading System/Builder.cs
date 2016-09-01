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
    public partial class Builder : Form
    {
        public Builder()
        {
            InitializeComponent();
        }

        private void Builder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void mnuReports_Click(object sender, EventArgs e)
        {
            Winforms.Report.Show();
        }

        private void mnuTransmutationTable_Click(object sender, EventArgs e)
        {
            Winforms.TransmutationTable.Show();
        }

        private void mnuGradeType_Click(object sender, EventArgs e)
        {
            Winforms.GradeType.Show();
        }

        private void mnuTemplates_Click(object sender, EventArgs e)
        {
            Winforms.Templates.Show();
            Winforms.Builder.Hide();
        }
    }
}
