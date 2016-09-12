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
using System.Xml;

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
            //
            // Settings Directory
            //
            bool settingsDirectoryExist = Directory.Exists(Path.GetFullPath(".\\") + FormControl.XML.FileStructure.settingsPath);
            if (!settingsDirectoryExist)
            {
                Directory.CreateDirectory(Path.GetFullPath(".\\") + FormControl.XML.FileStructure.settingsPath);
            }
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
                GS.validateWeight(lvActivitiesList, lvActivities, lblTotalWeight);
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
                flags.raise("modifyingstudent");
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
            flags.destroy("modifyingstudent");
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

        private void btnApplySection_Click(object sender, EventArgs e)
        {
            GS.applySection(txtSection, lvSection);
        }

        private void dummyData()
        {
            if (flags.isRaised("building"))
            {
                lvEntries.Items.Clear();
                GS.addEntry(lvSection, "Quiz", lvEntries, "Quiz 1", 150, 150);
                GS.addEntry(lvSection, "Quiz", lvEntries, "Quiz 2", 125, 150);
                GS.addEntry(lvSection, "Quiz", lvEntries, "Quiz 3", 75 + 40, 150);
                GS.addEntry(lvSection, "Quiz", lvEntries, "Quiz 4", 150, 150);
                GS.addEntry(lvSection, "Laboratory", lvEntries, "Lab 1", 25, 25);
                GS.addEntry(lvSection, "Laboratory", lvEntries, "Lab 2", 25, 25);
                GS.addEntry(lvSection, "Laboratory", lvEntries, "Lab 3", 25, 25);
                GS.addEntry(lvSection, "Seatwork", lvEntries, "SW 1", 25, 40);
                GS.addEntry(lvSection, "Seatwork", lvEntries, "SW 2", 20, 20);
                GS.addEntry(lvSection, "Exercise", lvEntries, "Exer 1", 20, 20);
                GS.addEntry(lvSection, "Exercise", lvEntries, "Exer 2", 29, 29);
                GS.addEntry(lvSection, "Exercise", lvEntries, "Exer 3", 24, 24);
                GS.addEntry(lvSection, "Exercise", lvEntries, "Exer 4", 35, 35);
                GS.addEntry(lvSection, "Exercise", lvEntries, "Exer 5", 25, 25);
                GS.addEntry(lvSection, "Finals", lvEntries, "Finals", 35, 50);

                lvActivities.Items.Clear();
                ListViewItem lvi;

                lvi = new ListViewItem("Quiz");
                lvi.SubItems.Add("50");
                lvActivities.Items.Add(lvi);

                lvi = new ListViewItem("Finals");
                lvi.SubItems.Add("20");
                lvActivities.Items.Add(lvi);

                lvi = new ListViewItem("Exercise");
                lvi.SubItems.Add("10");
                lvActivities.Items.Add(lvi);

                lvi = new ListViewItem("Laboratory");
                lvi.SubItems.Add("10");
                lvActivities.Items.Add(lvi);

                lvi = new ListViewItem("Seatwork");
                lvi.SubItems.Add("10");
                lvActivities.Items.Add(lvi);
            }
            else
            {
                MessageBox.Show("Enter build mode first and select name");
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            dummyData();
        }

        private void imgBuild_Click(object sender, EventArgs e)
        {
            if (!flags.isRaised("modifyingstudent"))
            {
                FormControl.Build.BuildMode(imgBuild, groupClassList, lvSection);
            }
            else
            {
                MessageBox.Show("You are still in record edit mode", "Unable to enter build mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (flags.isRaised("building"))
            {
                tabBuilder.SelectTab(1);
            }
        }

        private void Builder_Resize(object sender, EventArgs e)
        {
            tabBuilder.Width = this.Width - 40;
            lvEntries.Width = this.Width - 40;
        }

        private void btnCancelEntry_Click(object sender, EventArgs e)
        {
            FormControl.Entries.Cancel(txtDescription, txtScore, txtMaxScore, btnAddEntry, btnUpdateEntry, btnDeleteEntry, btnCancelEntry, lvEntries);
        }

        private void lvEntries_Click(object sender, EventArgs e)
        {
            if (flags.isRaised("building"))
            {
                try
                {
                    txtDescription.Text = lvEntries.SelectedItems[0].SubItems[3].Text;
                    txtScore.Text = lvEntries.SelectedItems[0].SubItems[4].Text;
                    txtMaxScore.Text = lvEntries.SelectedItems[0].SubItems[5].Text;
                }
                catch { }
            }
        }

        private void btnUpdateEntry_Click(object sender, EventArgs e)
        {
            GS.modifyEntryChanges(txtDescription, txtScore, txtMaxScore, lvEntries);
            if (flags.isRaised("updatingentry"))
            {
                FormControl.Entries.Confirm(txtDescription, txtScore, txtMaxScore, btnAddEntry, btnUpdateEntry, btnDeleteEntry, btnCancelEntry, lvEntries);
                flags.destroy("updatingentry");
            }
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            GS.deleteEntry(lvEntries);
            if (flags.isRaised("deletingentry"))
            {
                FormControl.Entries.Delete(txtDescription, txtScore, txtMaxScore, btnAddEntry, btnUpdateEntry, btnDeleteEntry, btnCancelEntry, lvEntries);
                flags.destroy("deletingentry");
            }
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            GS.addEntry(lvSection, lvActivities, lvEntries);
        }

        private void lvEntries_DoubleClick(object sender, EventArgs e)
        {
            if (flags.isRaised("building"))
            {
                tabBuilder.SelectTab(1);
                FormControl.Entries.Edit(txtDescription, txtScore, txtMaxScore, btnAddEntry, btnUpdateEntry, btnDeleteEntry, btnCancelEntry, lvEntries);
            }
        }

        private void tabBuilder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabBuilder.SelectedIndex.Equals(2))
                {
                    GS.getResultNames(lvEntries, lvResults);
                }
                else if (tabBuilder.SelectedIndex.Equals(1))
                {
                    GS.validateWeight(lvActivitiesList, lvActivities, lblTotalWeight);
                }
            }
            catch { }
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
        }

        private void lvResults_Click(object sender, EventArgs e)
        {
            //GS.getTreeResultNodes(lvActivities, treeResult);
            GS.getResults(lblResultName, lblResultSection, lvResults, lvEntries, treeResult);
            GS.getResultsSummary(lvActivities, lvResults, lvEntries, treeResultSummary, txtWeightedAverage);
        }

        private void mnuLoader_Click(object sender, EventArgs e)
        {
            Winforms.Loader.Show();
            Winforms.Builder.Hide();
        }

        private void btnSaveSection_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoadSection_Click(object sender, EventArgs e)
        {
                        
        }

        private void mnuFileLoad_Click(object sender, EventArgs e)
        {
            try
            {
                dlgLoadClass.InitialDirectory = Path.GetFullPath(".\\") + FormControl.XML.FileStructure.settingsPath;
                dlgLoadClass.ShowDialog();
                FormControl.XML.LoadClassList(lvSection, lvActivities, lvEntries, dlgLoadClass, notifyIcon);
                GS.validateWeight(lvActivitiesList, lvActivities, lblTotalWeight);
            }
            catch { }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                dlgSaveClass.InitialDirectory = Path.GetFullPath(".\\") + FormControl.XML.FileStructure.settingsPath;
                dlgSaveClass.ShowDialog();
                FormControl.XML.SaveClassList(lvSection, lvActivities, lvEntries, dlgSaveClass, notifyIcon);
            }
            catch { }
        }

        private void tabActivity_Click(object sender, EventArgs e)
        {
            GS.validateWeight(lvActivitiesList, lvActivities, lblTotalWeight);
        }

        private void tabActivity_Validated(object sender, EventArgs e)
        {
            GS.validateWeight(lvActivitiesList, lvActivities, lblTotalWeight);
        }
    }
}
