using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public class compute
    {
        /// <summary>
        /// Get Activity Count
        /// </summary>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get Total Score
        /// </summary>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get Total Score of Items
        /// </summary>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get Percentage
        /// </summary>
        /// <param name="activityType"></param>
        /// <param name="activities"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Score divided by number of items
        /// </summary>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static double getScoreAve(string activityType, ListView targetList)
        {
            double result = 0;
            int numberOfItems = getActivityCount(activityType, targetList);
            result = getTotalScore(activityType, targetList) / numberOfItems;
            return Math.Round(result, 2);
        }

        /// <summary>
        /// Total score divided by number of items
        /// </summary>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static double getMaxScoreAve(string activityType, ListView targetList)
        {
            double result = 0;
            int numberOfItems = getActivityCount(activityType, targetList);
            result = getTotalScoreItems(activityType, targetList) / numberOfItems;
            return Math.Round(result, 2);
        }

        /// <summary>
        /// Get Average
        /// </summary>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static double getWeightedAverage(string activityType,ListView targetList)
        {
            double result = 0;
            result = (getScoreAve(activityType, targetList) / getMaxScoreAve(activityType, targetList)) * 100;
            return Math.Round(result,2);
        }
    }
}
