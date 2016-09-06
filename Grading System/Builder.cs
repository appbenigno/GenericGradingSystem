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

        private void lvActivities_DoubleClick(object sender, EventArgs e)
        {
            lvActivitiesList.Enabled = false; lvActivities.Enabled = false; btnAdd.Enabled = false; btnRemove.Enabled = false; txtWeight.Enabled = true;
            txtWeight.Focus();
            GS.editActivity(lvActivities, txtWeight);
        }

        private void lvActivitiesList_DoubleClick(object sender, EventArgs e)
        {
            GS.addremActivity(lvActivitiesList, lvActivities);
        }

        private void txtWeight_Click(object sender, EventArgs e)
        {
            txtWeight.Select(0, txtWeight.TextLength);
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtWeight.Text);
            }
            catch
            {
                txtWeight.Text = "0";
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GS.modifyActivityChanges(txtWeight, lvActivities);
                GS.validateWeight(lvActivities, lblTotalWeight);
                if (GS.getWeight(lvActivities) <= 100)
                {
                    txtWeight.Enabled = false; lvActivities.Enabled = true; lvActivitiesList.Enabled = true; btnAdd.Enabled = true; btnRemove.Enabled = true;
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            GS.addStudent(txtSection, txtFamilyName, txtGivenName, txtMiddleInitial, lvSection);
        }
    }
}
