using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public static class Winforms
    {
        private static Form transmutationTable;

        public static Form TransmutationTable
        {
            get
            {
                if (transmutationTable == null)
                {
                    transmutationTable = new Transmutation();
                }
                return transmutationTable;
            }
        }

        private static Form gradeType;
        public static Form GradeType
        {
            get
            {
                if (gradeType == null)
                {
                    gradeType = new GradeType();
                }
                return gradeType;
            }
        }

        private static Form report;
        public static Form Report
        {
            get
            {
                if (report == null)
                {
                    report = new Report();
                }
                return report;
            }
        }

        private static Form templates;
        public static Form Templates
        {
            get
            {
                if (templates == null)
                {
                    templates = new Templates();
                }
                return templates;
            }
        }

        private static Form login;
        public static Form Login
        {
            get
            {
                if (login == null)
                {
                    login = new Login();
                }
                return login;
            }
        }

        private static Form builder;
        public static Form Builder
        {
            get
            {
                if (builder == null)
                {
                    builder = new Builder();
                }
                return builder;
            }
        }
    }
}
