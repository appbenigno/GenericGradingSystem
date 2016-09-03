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
        //----------
        // Builder
        //----------
        public static void getActivities(ListView targetListView)
        {
            ListViewItem lv;

            lv = new ListViewItem("Capstone");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Drama");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Extracurricular");
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

            lv = new ListViewItem("Literary");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);

            lv = new ListViewItem("Music");
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

            lv = new ListViewItem("Thesis");
            lv.SubItems.Add("0");
            targetListView.Items.Add(lv);
        }

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

        public static void removeActivity(ListView fromList, ListView toList)
        {

        }


        //----------
        // Themes
        //----------
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
