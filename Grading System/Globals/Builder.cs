using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.Globals
{
    public class Builder
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
    }
}
