using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public class flags
    {
        private static List<string> flagger = new List<string> { };
        /// <summary>
        /// Raise Flag
        /// </summary>
        /// <param name="flagString"></param>
        public static void raise(string flagString)
        {
            flagger.Add(flagString.ToUpper());
        }
        
        /// <summary>
        /// Check Flags
        /// </summary>
        /// <param name="flagString"></param>
        /// <returns></returns>
        public static bool isRaised(string flagString)
        {
            bool result = false;
            if (flagger.Contains(flagString.ToUpper()))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Destroy Flag
        /// </summary>
        /// <param name="flagString"></param>
        public static void destroy(string flagString)
        {
            if (isRaised(flagString.ToUpper()))
            {
                flagger.Remove(flagString.ToUpper());
            }
        }
    }
}
