using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.Globals
{
    public class Transmutation
    {
        private static ListView transmuteTable = new ListView();

        public static ListView TransmuteTable
        {
            get
            {
                return transmuteTable;
            }

            set
            {
                transmuteTable = value;
            }
        }

        public static void transferTransmutation(ListView sourceList, ListView targetList)
        {
            targetList.Items.Clear();
            for (int x = 0; x < sourceList.Items.Count; x++)
            {
                ListViewItem lvi = new ListViewItem(sourceList.Items[x].SubItems[0].Text);
                lvi.SubItems.Add(sourceList.Items[x].SubItems[1].Text);
                lvi.SubItems.Add(sourceList.Items[x].SubItems[2].Text);
                lvi.SubItems.Add(sourceList.Items[x].SubItems[3].Text);
                lvi.SubItems.Add(sourceList.Items[x].SubItems[4].Text);

                targetList.Items.Add(lvi);
            }
          
        }
    }
}
