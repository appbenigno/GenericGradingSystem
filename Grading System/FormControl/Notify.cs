using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class Notify
    {
        public static void ShowBalloon(NotifyIcon notifyIcon, string notifyTitle, string notifyMessage, int notifyTime = 250)
        {
            notifyIcon.Visible = true;
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.BalloonTipTitle = notifyTitle;
            notifyIcon.BalloonTipText = notifyMessage;
            notifyIcon.BalloonTipIcon = ToolTipIcon.None;
            notifyIcon.ShowBalloonTip(notifyTime);
        }
    }
}
