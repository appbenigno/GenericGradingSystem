using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.Globals
{
    public interface iBuilder
    {
        void transferSection(ListView sourceSectionList, ListView variableSectionList);
        void transferEntries(ListView sourceEntriesList, ListView variableEntriesList);
        void transferActivities(ListView sourceActivitiesList, ListView variableActivitiesList);
    }
}
