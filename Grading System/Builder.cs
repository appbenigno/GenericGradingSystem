using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

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
            FormControl.Activities.Modify(lvActivitiesList, lvActivities, btnAdd, btnRemove, txtWeight);
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
                    FormControl.Activities.ModifyConfirm(lvActivitiesList, lvActivities, btnAdd, btnRemove, txtWeight);
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            GS.addStudent(txtSection, lvSection);
            if (flags.isRaised("addingstudent"))
            {
                FormControl.AddStudent.Confirm(lvSection);
                flags.destroy("addingstudent");
            }
            
        }

        private void lvSection_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FormControl.ModifyStudent.EditDetails(txtFamilyName, txtGivenName, txtMiddleInitial, btnUpdate, btnCancel,btnAddStudent, btnDeleteStudent, lvSection);
            }
            catch { }
        }

        private void lvSection_Click(object sender, EventArgs e)
        {
            GS.echoList(txtSection, txtFamilyName, txtGivenName, txtMiddleInitial, lvSection);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormControl.Cancel.EditStudent(txtFamilyName, txtGivenName, txtMiddleInitial, btnUpdate, btnCancel, btnAddStudent, btnDeleteStudent, lvSection);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GS.modifyStudent(txtSection, txtFamilyName, txtGivenName, txtMiddleInitial, lvSection);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            GS.deleteStudent(txtSection, txtFamilyName, txtGivenName, txtMiddleInitial, lvSection);
            if (flags.isRaised("deletingstudent"))
            {
                FormControl.DeleteStudent.Confirm(txtSection, txtFamilyName, txtGivenName, txtMiddleInitial, btnUpdate, btnCancel, btnAddStudent, btnDeleteStudent, lvSection);
                flags.destroy("deletingstudent");
            }
        }

        private void lvSection_Validated(object sender, EventArgs e)
        {
            GS.validateGlobalsEntries(lvEntries);
        }

        private void lvSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            GS.validateGlobalsEntries(lvEntries);
        }

        private void btnApplySection_Click(object sender, EventArgs e)
        {
            GS.applySection(txtSection, lvSection);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            double answer = Math.Round(compute.getAverage("Quiz", lvEntries) * 100 * compute.getPercentage("Quiz", lvActivities),2);
            MessageBox.Show(answer.ToString());
        }
    }
}
