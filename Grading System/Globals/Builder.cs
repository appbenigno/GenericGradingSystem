using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.Globals
{
    public class Builder : iBuilder
    {
        private static ListView entries = new ListView();

        public static ListView Entries
        {
            get
            {
                return entries;
            }

            set
            {
                entries = value;
            }
        }

        public static ListView Section
        {
            get
            {
                return section;
            }

            set
            {
                section = value;
            }
        }

        public static ListView Activities
        {
            get
            {
                return activities;
            }

            set
            {
                activities = value;
            }
        }

        private static ListView section = new ListView();

        private static ListView activities = new ListView();

        public void transferSection(ListView sourceSectionList, ListView destinationSectionList)
        {
            try
            {
                destinationSectionList.Items.Clear();
                for (int x = 0; x < sourceSectionList.Items.Count; x++)
                {
                    ListViewItem lvi = new ListViewItem(sourceSectionList.Items[x].SubItems[0].Text);
                    lvi.SubItems.Add(sourceSectionList.Items[x].SubItems[1].Text);
                    lvi.SubItems.Add(sourceSectionList.Items[x].SubItems[2].Text);
                    lvi.SubItems.Add(sourceSectionList.Items[x].SubItems[3].Text);

                    destinationSectionList.Items.Add(lvi);
                }
            }
            catch { }
        }

        public void transferEntries(ListView sourceEntriesList, ListView destinationEntriesList)
        {
            destinationEntriesList.Items.Clear();
            for (int x = 0; x < sourceEntriesList.Items.Count; x++)
            {
                ListViewItem lvi = new ListViewItem(sourceEntriesList.Items[x].SubItems[0].Text);
                lvi.SubItems.Add(sourceEntriesList.Items[x].SubItems[1].Text);
                lvi.SubItems.Add(sourceEntriesList.Items[x].SubItems[2].Text);
                lvi.SubItems.Add(sourceEntriesList.Items[x].SubItems[3].Text);
                lvi.SubItems.Add(sourceEntriesList.Items[x].SubItems[4].Text);
                lvi.SubItems.Add(sourceEntriesList.Items[x].SubItems[5].Text);

                destinationEntriesList.Items.Add(lvi);
            }
        }

        public void transferActivities(ListView sourceActivitiesList, ListView destinationActivitiesList)
        {
            destinationActivitiesList.Items.Clear();
            for (int x = 0; x < sourceActivitiesList.Items.Count; x++)
            {
                ListViewItem lvi = new ListViewItem(sourceActivitiesList.Items[x].SubItems[0].Text);
                lvi.SubItems.Add(sourceActivitiesList.Items[x].SubItems[1].Text);

                destinationActivitiesList.Items.Add(lvi);
            }
        }
    }

    public class Section
    {

    }
    public class Entries
    {

    }

    public class Results
    {

    }
}
