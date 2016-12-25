using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DesktopNotifier
{
    class Program
    {
        static void Main(string[] args)
        {

            var notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon("C:\\Users\\Geoff\\boot-logo-3.ico");
            notifyIcon.BalloonTipTitle = "Boot";
            notifyIcon.BalloonTipText = "Hello, World!";
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(10000);
        }
    }
}
