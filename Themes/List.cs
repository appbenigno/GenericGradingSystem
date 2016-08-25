using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GSThemes
{
    public class Lister
    {
        /// <summary>
        /// Templates
        /// </summary>
        /// 
        public enum TableTemplates
        {
            Simple,
            Blue
        };
        public static void AllTemplates(ListBox targetList)
        {
            targetList.Items.Clear();
            targetList.Items.Add(TableTemplates.Simple);
            targetList.Items.Add(TableTemplates.Blue);
        }
    }
}
