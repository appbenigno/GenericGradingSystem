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
        /// Get Activity Count by Name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static int getActivityCount(string name, string activityType, ListView targetList)
        {
            int result = 0;
            for (int x = 0; x < targetList.Items.Count; x++)
            {
                if (targetList.Items[x].SubItems[0].Text.Equals(name) && targetList.Items[x].SubItems[2].Text.Equals(activityType))
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
        /// Get Total Score by Name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static int getTotalScore(string name, string activityType, ListView targetList)
        {
            int result = 0;
            for (int x = 0; x < targetList.Items.Count; x++)
            {
                if (targetList.Items[x].SubItems[0].Text.Equals(name) && targetList.Items[x].SubItems[2].Text.Equals(activityType))
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
        /// Get Total Score of Items by Name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static int getTotalScoreItems(string name, string activityType, ListView targetList)
        {
            int result = 0;
            for (int x = 0; x < targetList.Items.Count; x++)
            {
                if (targetList.Items[x].SubItems[0].Text.Equals(name) && targetList.Items[x].SubItems[2].Text.Equals(activityType))
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
            try
            {
                for (int x = 0; x < activities.Items.Count; x++)
                {
                    if (activities.Items[x].SubItems[0].Text.Equals(activityType))
                    {
                        double value = Convert.ToDouble(activities.Items[x].SubItems[1].Text);
                        result = Math.Round(value / 100, 2);
                    }
                }
            }
            catch { }
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
            try
            {
                int numberOfItems = getActivityCount(activityType, targetList);
                result = getTotalScore(activityType, targetList) / numberOfItems;
            }
            catch { }
            return Math.Round(result, 2);
        }

        /// <summary>
        /// Get score ave by Name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static double getScoreAve(string name, string activityType, ListView targetList)
        {
            double result = 0;
            try
            {
                int numberOfItems = getActivityCount(name, activityType, targetList);
                result = getTotalScore(name, activityType, targetList) / numberOfItems;
            }
            catch { }
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
            try
            {
                int numberOfItems = getActivityCount(activityType, targetList);
                result = getTotalScoreItems(activityType, targetList) / numberOfItems;
            }
            catch { }
            return Math.Round(result, 2);
        }

        /// <summary>
        /// Get maxscore ave by Name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <returns></returns>
        public static double getMaxScoreAve(string name, string activityType, ListView targetList)
        {
            double result = 0;
            try
            {
                int numberOfItems = getActivityCount(name, activityType, targetList);
                result = getTotalScoreItems(name, activityType, targetList) / numberOfItems;
            }
            catch { }
            return Math.Round(result, 2);
        }

        /// <summary>
        /// Get Weighted Average
        /// </summary>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <param name="activities"></param>
        /// <returns></returns>
        public static double getWeightedAverage(string activityType,ListView targetList, ListView activities)
        {
            double result = 0;
            try
            {
                result = (getScoreAve(activityType, targetList) / getMaxScoreAve(activityType, targetList)) * 100 * getPercentage(activityType, activities);
            }
            catch { }
            return Math.Round(result,2);
        }

        /// <summary>
        /// Get Weighted Average by Name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="activityType"></param>
        /// <param name="targetList"></param>
        /// <param name="activities"></param>
        /// <returns></returns>
        public static double getWeightedAverage(string name, string activityType, ListView targetList, ListView activities)
        {
            double result = 0;
            try
            {
                result = (getScoreAve(name, activityType, targetList) / getMaxScoreAve(name, activityType, targetList)) * 100 * getPercentage(activityType, activities);
            }
            catch { }
            return Math.Round(result, 2);
        }

        /// <summary>
        /// Get GWA
        /// </summary>
        /// <param name="name"></param>
        /// <param name="activities"></param>
        /// <param name="entriesList"></param>
        /// <returns></returns>
        public static double getGWA(string name, ListView activities, ListView entriesList)
        {
            double gwa = 0;
            try
            {
                for (int x = 0; x < activities.Items.Count; x++)
                {
                    string activityName = activities.Items[x].SubItems[0].Text;
                    int activityWeight = Convert.ToInt32(activities.Items[x].SubItems[1].Text);

                    gwa += compute.getWeightedAverage(name, activityName, entriesList, activities);
                }
            }
            catch { }
            return Math.Round(gwa, 2);
        }

        /// <summary>
        /// Get GPA from range of GWA
        /// </summary>
        /// <param name="transmutationList"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string getPointAverage(ListView transmutationList, double val)
        {
            string result = "";
            try
            {
                for (int x = 0; x < transmutationList.Items.Count; x++)
                {
                    double min = Convert.ToDouble(transmutationList.Items[x].SubItems[0].Text);
                    double max = Convert.ToDouble(transmutationList.Items[x].SubItems[2].Text);
                    string equivalent = transmutationList.Items[x].SubItems[3].Text;
                    if (val.CompareTo(min).Equals(1) || val.CompareTo(min).Equals(0))
                    {
                        if (val.CompareTo(max).Equals(-1) || val.CompareTo(max).Equals(0))
                        {
                            result = equivalent;
                        }
                    }
                }
            }
            catch { }
            return result;
        }

        /// <summary>
        /// Extract remarks definition from range of GWA
        /// </summary>
        /// <param name="transmutationList"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string getRemarks(ListView transmutationList, double val)
        {
            string result = "";
            try
            {
                for (int x = 0; x < transmutationList.Items.Count; x++)
                {
                    double min = Convert.ToDouble(transmutationList.Items[x].SubItems[0].Text);
                    double max = Convert.ToDouble(transmutationList.Items[x].SubItems[2].Text);
                    string description = transmutationList.Items[x].SubItems[4].Text;
                    if (val.CompareTo(min).Equals(1) || val.CompareTo(min).Equals(0))
                    {
                        if (val.CompareTo(max).Equals(-1) || val.CompareTo(max).Equals(0))
                        {
                            result = description;
                        }
                    }
                }
            }
            catch { }
            return result;
        }
    }
}
