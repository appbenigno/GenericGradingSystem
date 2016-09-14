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

        /// <summary>
        /// K-12 Transmutation Table
        /// </summary>
        /// <param name="targetList"></param>
        public static void transmutationK12(ListView targetList)
        {
            targetList.Items.Clear();
            ListViewItem lvi;

            lvi = new ListViewItem("100");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("100");
            lvi.SubItems.Add("100");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("98.40");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("99.99");
            lvi.SubItems.Add("99");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("96.80");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("98.39");
            lvi.SubItems.Add("98");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("95.20");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("96.79");
            lvi.SubItems.Add("97");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("93.60");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("95.19");
            lvi.SubItems.Add("96");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("92");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("93.59");
            lvi.SubItems.Add("95");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("90.40");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("91.99");
            lvi.SubItems.Add("94");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("90.40");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("91.99");
            lvi.SubItems.Add("94");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("88.80");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("90.39");
            lvi.SubItems.Add("93");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("87.20");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("88.79");
            lvi.SubItems.Add("92");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("85.60");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("87.19");
            lvi.SubItems.Add("91");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("84");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("85.59");
            lvi.SubItems.Add("90");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("82.40");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("83.99");
            lvi.SubItems.Add("89");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("80.80");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("82.39");
            lvi.SubItems.Add("88");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("79.20");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("80.79");
            lvi.SubItems.Add("87");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("77.60");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("79.19");
            lvi.SubItems.Add("86");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("76");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("77.59");
            lvi.SubItems.Add("85");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("74.40");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("75.99");
            lvi.SubItems.Add("84");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("72.80");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("74.39");
            lvi.SubItems.Add("83");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("71.20");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("72.79");
            lvi.SubItems.Add("82");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("69.60");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("71.19");
            lvi.SubItems.Add("81");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("68");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("69.59");
            lvi.SubItems.Add("80");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("66.40");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("67.99");
            lvi.SubItems.Add("79");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("64.80");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("66.39");
            lvi.SubItems.Add("78");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("63.20");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("64.79");
            lvi.SubItems.Add("77");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("61.60");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("63.19");
            lvi.SubItems.Add("76");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("60");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("61.59");
            lvi.SubItems.Add("75");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("56");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("59.99");
            lvi.SubItems.Add("74");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("52");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("55.99");
            lvi.SubItems.Add("73");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("48");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("51.99");
            lvi.SubItems.Add("72");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("44");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("47.99");
            lvi.SubItems.Add("71");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("40");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("43.99");
            lvi.SubItems.Add("70");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("36");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("39.99");
            lvi.SubItems.Add("69");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("32");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("35.99");
            lvi.SubItems.Add("68");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("28");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("31.99");
            lvi.SubItems.Add("67");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("24");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("27.99");
            lvi.SubItems.Add("66");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("20");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("23.99");
            lvi.SubItems.Add("65");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("16");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("19.99");
            lvi.SubItems.Add("64");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("12");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("15.99");
            lvi.SubItems.Add("63");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("8");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("11.99");
            lvi.SubItems.Add("62");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("4");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("7.99");
            lvi.SubItems.Add("61");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("0");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("3.99");
            lvi.SubItems.Add("60");
            lvi.SubItems.Add("");
            targetList.Items.Add(lvi);
        }

        /// <summary>
        /// Mapua Transmutation Table
        /// </summary>
        /// <param name="targetList"></param>
        public static void transmutationMapua(ListView targetList)
        {
            targetList.Items.Clear();
            ListViewItem lvi;

            lvi = new ListViewItem("96.67");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("100.00");
            lvi.SubItems.Add("1.00");
            lvi.SubItems.Add("Excellent");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("93.33");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("96.66");
            lvi.SubItems.Add("1.25");
            lvi.SubItems.Add("Highly Meritorious");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("90.00");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("93.32");
            lvi.SubItems.Add("1.50");
            lvi.SubItems.Add("Meritorious");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("86.67");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("89.99");
            lvi.SubItems.Add("1.75");
            lvi.SubItems.Add("Meritorious");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("83.33");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("86.66");
            lvi.SubItems.Add("2.00");
            lvi.SubItems.Add("Very Satisfactory");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("80.00");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("83.32");
            lvi.SubItems.Add("2.25");
            lvi.SubItems.Add("Very Satisfactory");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("76.67");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("79.99");
            lvi.SubItems.Add("2.50");
            lvi.SubItems.Add("Satisfactory");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("73.33");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("76.66");
            lvi.SubItems.Add("2.75");
            lvi.SubItems.Add("Satisfactory");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("70.00");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("73.32");
            lvi.SubItems.Add("3.00");
            lvi.SubItems.Add("Lowest Passing Grade");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("50.00");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("69.99");
            lvi.SubItems.Add("5.00");
            lvi.SubItems.Add("	Failure");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("30.00");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("49.99");
            lvi.SubItems.Add("7.00");
            lvi.SubItems.Add("Incomplete");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("10.00");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("29.99");
            lvi.SubItems.Add("8.00");
            lvi.SubItems.Add("Absent");
            targetList.Items.Add(lvi);

            lvi = new ListViewItem("0.00");
            lvi.SubItems.Add("-");
            lvi.SubItems.Add("9.99");
            lvi.SubItems.Add("9.00");
            lvi.SubItems.Add("Dropped");
            targetList.Items.Add(lvi);
        }
    }
}
