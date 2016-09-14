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
        public static void validateWeight(ListView activitiesLister, ListView source,Label targetLabel)
        {
            try
            {
                for (int x = 0; x < source.Items.Count; x++)
                {
                    string match1 = source.Items[x].SubItems[0].Text;
                    for (int y = 0; y < activitiesLister.Items.Count; y++)
                    {
                        string match2 = activitiesLister.Items[y].SubItems[0].Text;
                        if (match2.Equals(match1))
                        {
                            activitiesLister.Items[y].Remove();
                        }
                    }
                }
            }
            catch { }
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
                    targetList.SelectedItems[0].SubItems[0].Text = section.Text;
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

                Globals.Report.Section = targetList.SelectedItems[0].SubItems[0].Text; ;
                Globals.Report.FamilyName = targetList.SelectedItems[0].SubItems[1].Text;
                Globals.Report.GivenName = targetList.SelectedItems[0].SubItems[2].Text; ;
                Globals.Report.MiddleInitial = targetList.SelectedItems[0].SubItems[3].Text;
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

        /// <summary>
        /// Delete selected entry
        /// </summary>
        /// <param name="targetList"></param>
        public static void deleteEntry(ListView targetList)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                targetList.SelectedItems[0].Remove();
                flags.raise("deletingentry");
            }
        }

        /// <summary>
        /// Modify selected entry
        /// </summary>
        /// <param name="description"></param>
        /// <param name="score"></param>
        /// <param name="maxscore"></param>
        /// <param name="sourceList"></param>
        public static void modifyEntryChanges(TextBox description, TextBox score, TextBox maxscore, ListView sourceList)
        {
            if (description.TextLength < 1 || maxscore.TextLength < 1)
            {
                MessageBox.Show("Description and max score fields are mandatory", "Mandatory fields empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (score.TextLength<1)
                {
                    sourceList.SelectedItems[0].SubItems[3].Text = description.Text;
                    sourceList.SelectedItems[0].SubItems[4].Text = "0";
                    sourceList.SelectedItems[0].SubItems[5].Text = maxscore.Text;
                }
                else
                {
                    sourceList.SelectedItems[0].SubItems[3].Text = description.Text;
                    sourceList.SelectedItems[0].SubItems[4].Text = score.Text;
                    sourceList.SelectedItems[0].SubItems[5].Text = maxscore.Text;
                }
                flags.raise("updatingentry");
                MessageBox.Show("Selected entry updated.", "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Add a new entry A
        /// </summary>
        /// <param name="classList"></param>
        /// <param name="activityList"></param>
        /// <param name="entriesList"></param>
        public static void addEntry(ListView classList, ListView activityList, ListView entriesList)
        {
            if (flags.isRaised("building"))
            {
                try
                {
                    for (int x = 0; x < activityList.Items.Count; x++)
                    {
                        if (activityList.Items[x].Selected)
                        {
                            flags.raise("activityselected");
                            break;
                        }
                        else
                        {
                            flags.raise("noactivityselected");
                        }
                    }
                    if (flags.isRaised("noactivityselected"))
                    {
                        flags.destroy("noactivityselected");
                        MessageBox.Show("Select an activity name first.", "No activity selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (flags.isRaised("activityselected"))
                    {
                        string name = string.Concat(classList.SelectedItems[0].SubItems[1].Text, ", ", classList.SelectedItems[0].SubItems[2].Text, " ", classList.SelectedItems[0].SubItems[3].Text, ".");
                        string section = classList.SelectedItems[0].SubItems[0].Text;
                        string activity = activityList.SelectedItems[0].SubItems[0].Text;
                        string description = Microsoft.VisualBasic.Interaction.InputBox("Enter description", "Description");
                        int score = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter score", "Score", "0"));
                        int maxscore = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter max score", "Maximum Score", "100"));

                        ListViewItem lvi = new ListViewItem(name);
                        lvi.SubItems.Add(section);
                        lvi.SubItems.Add(activity);
                        lvi.SubItems.Add(description);
                        lvi.SubItems.Add(score.ToString());
                        lvi.SubItems.Add(maxscore.ToString());

                        entriesList.Items.Add(lvi);
                    }
                }
                catch (Exception errAdd)
                {
                    MessageBox.Show(errAdd.Message, "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Unable to create entry without selecting a name from the class list and entering build mode.", "Enter build mode first", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Add a new entry B
        /// </summary>
        /// <param name="classList"></param>
        /// <param name="activityList"></param>
        /// <param name="entriesList"></param>
        /// <param name="description"></param>
        /// <param name="score"></param>
        /// <param name="maxscore"></param>
        public static void addEntry(ListView classList, string activityName, ListView entriesList, string description, int score=0, int maxscore=100)
        {
            if (flags.isRaised("building"))
            {
                try
                {
                    string name = string.Concat(classList.SelectedItems[0].SubItems[1].Text, ", ", classList.SelectedItems[0].SubItems[2].Text, " ", classList.SelectedItems[0].SubItems[3].Text, ".");
                    string section = classList.SelectedItems[0].SubItems[0].Text;
                    string activity = activityName;

                    ListViewItem lvi = new ListViewItem(name);
                    lvi.SubItems.Add(section);
                    lvi.SubItems.Add(activity);
                    lvi.SubItems.Add(description);
                    lvi.SubItems.Add(score.ToString());
                    lvi.SubItems.Add(maxscore.ToString());

                    entriesList.Items.Add(lvi);
                }
                catch (Exception errAdd)
                {
                    MessageBox.Show(errAdd.Message, "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Unable to create entry without selecting a name and entering build mode.", "Enter build mode first", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Get distinct names from Entires List
        /// </summary>
        /// <param name="entriesList"></param>
        /// <param name="resultsList"></param>
        public static void getResultNames(ListView entriesList, ListView resultsList)
        {
            try
            {
                resultsList.Items.Clear();
                if (entriesList.Items.Count > 0)
                {
                    for (int x = 0; x < entriesList.Items.Count; x++)
                    {
                        string name = entriesList.Items[x].SubItems[0].Text;
                        string section = entriesList.Items[x].SubItems[1].Text;

                        ListViewItem lvi = new ListViewItem(name);
                        lvi.SubItems.Add(section);

                        if (!isResultExist(resultsList, name)) 
                        {
                            resultsList.Items.Add(lvi);
                        }
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Check duplicate name entry in results
        /// </summary>
        /// <param name="resultList"></param>
        /// <param name="matchString"></param>
        /// <returns></returns>
        public static bool isResultExist(ListView resultList, string matchString)
        {
            bool result = false;
            for (int x = 0; x < resultList.Items.Count; x++)
            {
                string tomatch = resultList.Items[x].SubItems[0].Text;
                if (matchString.Equals(tomatch))
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        /// <summary>
        /// Get activity count by Name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="activityName"></param>
        /// <param name="entriesList"></param>
        /// <returns></returns>
        public static int getActivityCount(string name, string activityName, ListView entriesList)
        {
            int result = 0;
            for (int x = 0; x < entriesList.Items.Count; x++)
            {
                string matchname = entriesList.Items[x].SubItems[0].Text;
                string matchactivity = entriesList.Items[x].SubItems[2].Text;
                if (matchname.Equals(name) && matchactivity.Equals(activityName))
                {
                    result += 1;
                }   
            }
            return result;
        }

        /// <summary>
        /// Get tree nodes from listview items
        /// </summary>
        /// <param name="sourceList"></param>
        /// <param name="resultTree"></param>
        public static void getTreeResultNodes(ListView sourceList, TreeView resultTree)
        {
            try
            {
                resultTree.Nodes.Clear();
                for (int x = 0; x < sourceList.Items.Count; x++)
                {
                    resultTree.Nodes.Add(sourceList.Items[x].SubItems[0].Text);
                }
            }
            catch { }
        }

        /// <summary>
        /// Get Results
        /// </summary>
        /// <param name="targetNameLabel"></param>
        /// <param name="targetSectionLabel"></param>
        /// <param name="resultList"></param>
        /// <param name="entriesList"></param>
        /// <param name="resultTree"></param>
        public static void getResults(Label targetNameLabel, Label targetSectionLabel, ListView resultList, ListView entriesList, TreeView resultTree)
        {
            try
            {
                targetNameLabel.Text = resultList.SelectedItems[0].SubItems[0].Text;
                targetSectionLabel.Text = resultList.SelectedItems[0].SubItems[1].Text;
                resultTree.Nodes.Clear();

                for (int x = 0; x < entriesList.Items.Count; x++)
                {
                    string name = entriesList.Items[x].SubItems[0].Text;
                    string activity = entriesList.Items[x].SubItems[2].Text;
                    string description = entriesList.Items[x].SubItems[3].Text;
                    int score = Convert.ToInt32(entriesList.Items[x].SubItems[4].Text);
                    int maxscore = Convert.ToInt32(entriesList.Items[x].SubItems[5].Text);
                    if (name.Equals(targetNameLabel.Text))
                    {
                        TreeNode noder = new TreeNode(activity);
                        noder.Nodes.Add(string.Concat("Description: ",description));
                        noder.Nodes.Add(string.Concat("Score: ", score.ToString()));
                        noder.Nodes.Add(string.Concat("Max Score: ", maxscore.ToString()));
                        resultTree.Nodes.Add(noder);
                        
                    }
                }
                resultTree.Sort();
            }
            catch { }
        }

        /// <summary>
        /// Get Summary Results to TreeView
        /// </summary>
        /// <param name="activities"></param>
        /// <param name="resultList"></param>
        /// <param name="entriesList"></param>
        /// <param name="resultTree"></param>
        /// <param name="resultLabel"></param>
        public static void getResultsSummary(ListView activities, ListView resultList, ListView entriesList, TreeView resultTree, TextBox resultLabel)
        {
            resultTree.Nodes.Clear();
            string name = resultList.SelectedItems[0].SubItems[0].Text;
            string section = resultList.SelectedItems[0].SubItems[1].Text;
            TreeNode noder;
            

            for (int x = 0; x < activities.Items.Count; x++)
            {
                string activityName;
                int activityWeight;
                activityName = activities.Items[x].SubItems[0].Text;
                activityWeight = Convert.ToInt32(activities.Items[x].SubItems[1].Text);
                noder = new TreeNode(string.Concat(activityName, " ", activityWeight.ToString(), "%"));
                noder.Nodes.Add(string.Concat("Count = ", compute.getActivityCount(name, activityName, entriesList)));
                noder.Nodes.Add(string.Concat("Total Score = ", compute.getTotalScore(name, activityName, entriesList)));
                noder.Nodes.Add(string.Concat("Total Max Score = ", compute.getTotalScoreItems(name, activityName, entriesList)));
                noder.Nodes.Add(string.Concat("Score Ave. = ", compute.getScoreAve(name, activityName, entriesList)));
                noder.Nodes.Add(string.Concat("Max Score Ave. = ", compute.getMaxScoreAve(name, activityName, entriesList)));
                noder.Nodes.Add(string.Concat("Weighted Ave. = ", compute.getWeightedAverage(name, activityName, entriesList, activities)));
                resultTree.Nodes.Add(noder);
            }

            double wa = 0;
            for (int y = 0; y < activities.Items.Count; y++)
            {
                string activityName2;
                int activityWeight2;
                activityName2 = activities.Items[y].SubItems[0].Text;
                activityWeight2 = Convert.ToInt32(activities.Items[y].SubItems[1].Text);

                wa += compute.getWeightedAverage(name, activityName2, entriesList, activities);
            }
            resultLabel.Text = Math.Round(wa, 2).ToString();

            Globals.Report.Gwa = Math.Round(wa, 2);
            Globals.Report.Gpa = compute.getPointAverage(Globals.Transmutation.TransmuteTable, Globals.Report.Gwa);
            Globals.Report.Remarks = compute.getRemarks(Globals.Transmutation.TransmuteTable, Globals.Report.Gwa);
            
            resultTree.Sort();
            resultTree.ExpandAll();
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
