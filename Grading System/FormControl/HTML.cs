using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web.UI;
using GSThemes;

namespace Grading_System.FormControl
{
    public class HTML
    {
        public class FileStructure
        {
            public static string htmlPath = "reports";
        }

        public static void Write(Label selectedTheme, ListView activityList, ListView entryList)
        {
            if (selectedTheme.Text.Equals("Simple"))
            {
                StreamWriter xWrite = new StreamWriter("test.html");
                xWrite.WriteLine(Globals.Templates.Simple(activityList, entryList));
                xWrite.Close();
            }
            else if (selectedTheme.Text.Equals("Blue"))
            {
                StreamWriter xWrite = new StreamWriter("test.html");
                xWrite.WriteLine(Globals.Templates.Blue(activityList, entryList));
                xWrite.Close();
            }
        } 

        
    }
}
