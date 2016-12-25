using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

using CommandLine;
using CommandLine.Text;
using System.Threading;

namespace DesktopNotifier
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {

            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                DisplayNotification(options);
            }
        }

        static void DisplayNotification(Options options)
        {
            var notifyIcon = new NotifyIcon();

            if (options.iconPath != null)
                notifyIcon.Icon = new Icon(options.iconPath);
            else
                notifyIcon.Icon = Properties.Resources.CommandPromptIcon;

            notifyIcon.BalloonTipTitle = options.title;
            notifyIcon.BalloonTipText = options.message;

            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(options.showTime);
        }
    }

    class Options
    {
        // Required
        [Option('m', "message", Required = true, DefaultValue = "Hello, World", HelpText = "The message to display.")]
        public string message { get; set; }
        
        // Optional
        [Option('t', "title", Required = true, DefaultValue = "Terminal", HelpText = "The title text to display.")]
        public string title { get; set; }

        [Option('i', "icon", Required = false, HelpText = "The path to a .ico file to display.")]
        public string iconPath { get; set; }

        [Option('s', "showTime", Required = false, DefaultValue = 10000, HelpText = "The length of time to show notification for in milliseconds.")]
        public int showTime { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
