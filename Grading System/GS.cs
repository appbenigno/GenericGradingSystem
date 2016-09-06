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

            lv = new ListViewItem("Practical");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Practicum");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Project");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Quiz");
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

        public static void addStudent(TextBox section, TextBox familyName, TextBox givenName, TextBox middleInitial, ListView targetList)
        {
            if (section.Text.Length > 0 && familyName.Text.Length > 0 && givenName.Text.Length > 0 && middleInitial.Text.Length > 0)
            {
                ListViewItem lv = new ListViewItem(section.Text);
                lv.SubItems.Add(familyName.Text);
                lv.SubItems.Add(givenName.Text);
                lv.SubItems.Add(middleInitial.Text);

                if (targetList.Items.Contains(lv))
                {
                    MessageBox.Show(string.Concat("'", familyName.Text, ", ", givenName.Text, " ", middleInitial.Text, ".", "'", " already exists!"), "Duplicate record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    targetList.Items.Add(lv);
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory!", "Empty field(s) detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void modifyStudent(TextBox section, TextBox familyName, TextBox givenName, TextBox middleInitial, ListView targetList)
        {

        }
        public static void deleteStudent(TextBox section, TextBox familyName, TextBox givenName, TextBox middleInitial, ListView targetList)
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
