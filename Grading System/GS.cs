using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public class GS
    {
        /// <summary>
        /// Templates
        /// </summary>
        public enum TableTemplates
        {
            Nothing,
            Simple,
            Basic,
            Corporate,
        };

        private static TableTemplates outputView = TableTemplates.Nothing;
        public static TableTemplates OutputView
        {
            get
            {
                return outputView;
            }
            set
            {
                outputView = value;
            }
        }

        public static void setTemplate(TableTemplates tableTemplates, ToolStripStatusLabel statusNotify)
        {
            OutputView = tableTemplates;
            statusNotify.Text = OutputView.ToString();
        }
    }
}
