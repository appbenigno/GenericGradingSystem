using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public class compute
    {
        public static int getActivityCount(string activityType, ListView targetList)
        {
            int result = 0;
            for (int x = 0; x < targetList.Items.Count; x++)
            {
                if (targetList.Items[x].SubItems[2].Text.Equals(activityType))
                {
                    result += 1;
                }
            }
            return result;
        }
        public static int getTotalScore(string activityType,ListView targetList)
        {
            int result = 0;
            for (int x = 0; x < targetList.Items.Count; x++)
            {
                if(targetList.Items[x].SubItems[2].Text.Equals(activityType))
                {
                    result += Convert.ToInt32(targetList.Items[x].SubItems[4].Text);
                }
            }
            return result;
        }
        public static int getTotalScoreItems(string activityType, ListView targetList)
        {
            int result = 0;
            for (int x = 0; x < targetList.Items.Count; x++)
            {
                if (targetList.Items[x].SubItems[2].Text.Equals(activityType))
                {
                    result += Convert.ToInt32(targetList.Items[x].SubItems[5].Text);
                }
            }
            return result;
        }

        public static double getPercentage(string activityType, ListView activities)
        {
            double result = 0;
            for (int x = 0; x < activities.Items.Count; x++)
            {
                if(activities.Items[x].SubItems[0].Text.Equals(activityType))
                {
                    double value = Convert.ToDouble(activities.Items[x].SubItems[1].Text);
                    result = Math.Round(value / 100, 2);
                }
            }
            return result;
        }
        public static double getAverage(string activityType,ListView targetList)
        {
            double result = 0;
            double score = getTotalScore(activityType, targetList);
            double maxscore = getTotalScoreItems(activityType, targetList);
            double items = getActivityCount(activityType, targetList);
            result = Math.Round(score / maxscore,2);
            return result;
        }
    }
}
