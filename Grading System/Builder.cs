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

        private void Builder_Load(object sender, EventArgs e)
        {
            GS.getActivities(lvActivitiesList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GS.addremActivity(lvActivitiesList, lvActivities);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GS.addremActivity(lvActivities, lvActivitiesList);
        }
    }
}
