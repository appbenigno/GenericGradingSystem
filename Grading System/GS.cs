using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSThemes;

namespace Grading_System
{
    public class GS
    {
        //--------------------------------------------------
        // Builder
        //--------------------------------------------------

        /// <summary>
        /// Populate Activity List
        /// </summary>
        /// <param name="targetListView"></param>
        public static void getActivities(ListView targetListView)
        {
            ListViewItem lv;

            lv = new ListViewItem("Attendance");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Capstone");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Character");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Dance");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Defense");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Drama");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Exercise");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Finals");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Forensic");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Homework");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Laboratory");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Literary");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Music");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Others");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Practical");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Project");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Quiz");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Recitation");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Seatwork");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Speech");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Thesis");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);
        }

        /// <summary>
        /// Edit selected activity item
        /// </summary>
        /// <param name="targetList"></param>
        /// <param name="targetTextbox"></param>
        public static void editActivity(ListView targetList, TextBox targetTextbox)
        {
            targetTextbox.Text = targetList.SelectedItems[0].SubItems[1].Text;
        }

        /// <summary>
        /// Update activity changes
        /// </summary>
        /// <param name="changes"></param>
        /// <param name="targetList"></param>
        public static void modifyActivityChanges(TextBox changes, ListView targetList)
        {
            targetList.SelectedItems[0].SubItems[1].Text = changes.Text;
        }

        /// <summary>
        /// Add or Remove Activity
        /// </summary>
        /// <param name="fromList"></param>
        /// <param name="toList"></param>
        public static void addremActivity(ListView fromList, ListView toList)
        {
            try
            {
                ListViewItem lv = new ListViewItem(fromList.SelectedItems[0].SubItems[0].Text);
                lv.SubItems.Add(fromList.SelectedItems[0].SubItems[1].Text);
                toList.Items.Add(lv);
                fromList.SelectedItems[0].Remove();
            }
            catch { }
        }

        /// <summary>
        /// Get the total Weight
        /// </summary>
        /// <param name="sourceList"></param>
        /// <returns></returns>
        public static int getWeight(ListView sourceList)
        {
            int result = 0;
            int sum = 0;
            try
            {
                for (int x = 0; x < sourceList.Items.Count; x++)
                {
                    sum = Convert.ToInt32(sourceList.Items[x].SubItems[1].Text);
                    result += sum;
                }
            }
            catch { }
            return result;
        }

        /// <summary>
        /// Validate weight
        /// </summary>
        /// <param name="source"></param>
        /// <param name="targetLabel"></param>
        public static void validateWeight(ListView source,Label targetLabel)
        {
            targetLabel.Text = string.Concat(getWeight(source).ToString(), "%");
            if (getWeight(source) > 100)
            {
                MessageBox.Show("Overall weight must not exceed 100% and must be 100% in total", "Overall weight error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Add Student
        /// </summary>
        /// <param name="section"></param>
        /// <param name="targetList"></param>
        public static void addStudent(TextBox section, ListView targetList)
        {
            string familyName = Microsoft.VisualBasic.Interaction.InputBox("Input Family Name",section.Text);
            string givenName = Microsoft.VisualBasic.Interaction.InputBox("Input Given Name", section.Text);
            string middleInitial = Microsoft.VisualBasic.Interaction.InputBox("Input Middle Initial", section.Text);
            
            if (familyName.Length > 0 && givenName.Length > 0 && middleInitial.Length > 0)
            {
                if (!GS.isStudentExist(familyName, givenName, middleInitial, targetList))
                {
                    flags.raise("addingstudent");
                    ListViewItem lv = new ListViewItem(section.Text);
                    lv.SubItems.Add(familyName);
                    lv.SubItems.Add(givenName);
                    lv.SubItems.Add(middleInitial);
                    targetList.Items.Add(lv);
                }
                else
                {
                    MessageBox.Show("Existing Record found in current section!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory!", "Empty field(s) detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modify Student
        /// </summary>
        /// <param name="section"></param>
        /// <param name="familyName"></param>
        /// <param name="givenName"></param>
        /// <param name="middleInitial"></param>
        /// <param name="targetList"></param>
        public static void modifyStudent(TextBox section, TextBox familyName, TextBox givenName, TextBox middleInitial, ListView targetList)
        {
            try
            {
                if (familyName.Text.Length > 0 && givenName.Text.Length > 0 && middleInitial.Text.Length > 0)
                {
                    targetList.SelectedItems[0].SubItems[1].Text = familyName.Text;
                    targetList.SelectedItems[0].SubItems[2].Text = givenName.Text;
                    targetList.SelectedItems[0].SubItems[3].Text = middleInitial.Text;
                }
                else
                {
                    MessageBox.Show("All fields are mandatory!", "Missing data detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Select an entry first", "No selected entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Delete Student
        /// </summary>
        /// <param name="section"></param>
        /// <param name="familyName"></param>
        /// <param name="givenName"></param>
        /// <param name="middleInitial"></param>
        /// <param name="targetList"></param>
        public static void deleteStudent(TextBox section, TextBox familyName, TextBox givenName, TextBox middleInitial, ListView targetList)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    flags.raise("deletingstudent");
                    section.Text = ""; familyName.Text = ""; givenName.Text = ""; middleInitial.Text = "";
                    targetList.SelectedItems[0].Remove();
                }
            }
            catch { }
        }

        /// <summary>
        /// Check duplicate entry
        /// </summary>
        /// <param name="familyName"></param>
        /// <param name="givenName"></param>
        /// <param name="middleInitial"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static bool isStudentExist(TextBox familyName, TextBox givenName, TextBox middleInitial, ListView targetList)
        {
            string fn = "", gn = "", mi = "";
            bool result = false;
            for (int x = 0; x < targetList.Items.Count; x++)
            {
                fn = targetList.Items[x].SubItems[1].Text;
                gn = targetList.Items[x].SubItems[2].Text;
                mi = targetList.Items[x].SubItems[3].Text;
                if(familyName.Text.Equals(fn) && givenName.Text.Equals(gn) && middleInitial.Text.Equals(mi))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Check duplicate entry
        /// </summary>
        /// <param name="familyName"></param>
        /// <param name="givenName"></param>
        /// <param name="middleInitial"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static bool isStudentExist(string familyName, string givenName, string middleInitial, ListView targetList)
        {
            string fn = "", gn = "", mi = "";
            bool result = false;
            for (int x = 0; x < targetList.Items.Count; x++)
            {
                fn = targetList.Items[x].SubItems[1].Text;
                gn = targetList.Items[x].SubItems[2].Text;
                mi = targetList.Items[x].SubItems[3].Text;
                if (familyName.Equals(fn) && givenName.Equals(gn) && middleInitial.Equals(mi))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Echo selected item from ListView to Textboxes
        /// </summary>
        /// <param name="section"></param>
        /// <param name="familyName"></param>
        /// <param name="givenName"></param>
        /// <param name="middleInitial"></param>
        /// <param name="targetList"></param>
        public static void echoList(TextBox section, TextBox familyName, TextBox givenName, TextBox middleInitial, ListView targetList)
        {
            try
            {
                section.Text = targetList.SelectedItems[0].SubItems[0].Text;
                familyName.Text = targetList.SelectedItems[0].SubItems[1].Text;
                givenName.Text = targetList.SelectedItems[0].SubItems[2].Text;
                middleInitial.Text = targetList.SelectedItems[0].SubItems[3].Text;
            }
            catch { }
        }

        /// <summary>
        /// Validate Entires Global Variable
        /// </summary>
        /// <param name="targetList"></param>
        public static void validateGlobalsEntries(ListView targetList)
        {
            Globals.Builder.Entries.Items.Clear();
            try
            {
                for (int x = 0; x < targetList.Items.Count; x++)
                {
                    ListViewItem lv = new ListViewItem(targetList.Items[x].SubItems[0].Text);
                    lv.SubItems.Add(targetList.Items[x].SubItems[1].Text);
                    lv.SubItems.Add(targetList.Items[x].SubItems[2].Text);
                    lv.SubItems.Add(targetList.Items[x].SubItems[3].Text);
                    lv.SubItems.Add(targetList.Items[x].SubItems[4].Text);
                    lv.SubItems.Add(targetList.Items[x].SubItems[5].Text);
                    Globals.Builder.Entries.Items.Add(lv);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Applies section to all list
        /// </summary>
        /// <param name="targetList"></param>
        public static void applySection(TextBox section, ListView targetList)
        {
            if (targetList.Items.Count > 0)
            {
                for (int x = 0; x < targetList.Items.Count; x++)
                {
                    targetList.Items[x].SubItems[0].Text = section.Text;
                }
                MessageBox.Show(string.Concat("Section: '", section.Text, "' has been applied to current class list."), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Concat("No students in current class to apply the section: ",section.Text), "Empty section", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void deleteEntry(ListView targetList)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                targetList.SelectedItems[0].Remove();
            }
        }

        public static void editEntry()
        {

        }

        //--------------------------------------------------
        // Themes
        //--------------------------------------------------

        /// <summary>
        /// Populate Theme List
        /// </summary>
        /// <param name="targetListbox"></param>
        public static void getThemes(ListBox targetListbox)
        {
            try
            {
                Lister.AllTemplates(targetListbox);
            }
            catch
            {
                MessageBox.Show("Unable to populate themes list. External file library 'GSThemes.dll' is missing or corrupt.\nThe program will load the default theme instead.", "Error Loading Templates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                targetListbox.Items.Clear();
                targetListbox.Items.Add("Simple");
            }
        }
    }
}
