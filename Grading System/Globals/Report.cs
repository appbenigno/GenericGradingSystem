using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.Globals
{
    public class Report
    {
        private static string familyName = "";
        private static string givenName = "";
        private static string middleInitial = "";
        private static string section = "";
        private static string period = "";
        private static string remarks = "";
        private static string gpa = "0";
        private static double gwa = 0;

        public static string Name
        {
            get
            {
                return string.Concat(familyName, ", ", givenName, " ", middleInitial, ".");
            }
        }

        public static string FamilyName
        {
            get
            {
                return familyName;
            }

            set
            {
                familyName = value;
            }
        }

        public static string GivenName
        {
            get
            {
                return givenName;
            }

            set
            {
                givenName = value;
            }
        }

        public static string MiddleInitial
        {
            get
            {
                return middleInitial;
            }

            set
            {
                middleInitial = value;
            }
        }

        public static string Section
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

        public static string Period
        {
            get
            {
                return period;
            }

            set
            {
                period = value;
            }
        }

        public static string Remarks
        {
            get
            {
                return remarks;
            }

            set
            {
                remarks = value;
            }
        }

        public static string Gpa
        {
            get
            {
                return gpa;
            }

            set
            {
                gpa = value;
            }
        }

        public static double Gwa
        {
            get
            {
                return gwa;
            }

            set
            {
                gwa = value;
            }
        }
    }
}
