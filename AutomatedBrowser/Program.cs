using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatedBrowser.Properties;
using System.IO;
using System.Drawing;
using AutomatedBrowser.Utils;
using System.Runtime;

namespace AutomatedBrowser
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static RichTextBox console;
        [STAThread]
        static void Main()
        {

            using (var consoleWriter = new ConsoleWriter())
            {
                consoleWriter.WriteEvent += consoleWriter_WriteEvent;
                consoleWriter.WriteLineEvent += consoleWriter_WriteLineEvent;

                Console.SetOut(consoleWriter);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                InitCef();


                Application.Run(new MainForm());
            }
        }
        static void InitCef()
        {
            CefSettings settings = new CefSettings();
            if (settings.CefCommandLineArgs.ContainsKey("enable-system-flash"))
                settings.CefCommandLineArgs.Remove("enable-system-flash");
            settings.CefCommandLineArgs.Add("enable-system-flash", string.Empty);
            settings.CefCommandLineArgs.Add("ppapi-flash-path", AppContext.BaseDirectory + "Flash\\pepflashplayer.dll");
            settings.CefCommandLineArgs.Add("ppapi-flash-version", "32.0.0.371");
            settings.CefCommandLineArgs["plugin-policy"] = "allow";
            settings.CefCommandLineArgs.Add("allow-outdated-plugins", "1");
            settings.CachePath = Path.GetFullPath("cache");

            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            var contx = Cef.GetGlobalRequestContext();
            Cef.UIThreadTaskFactory.StartNew(delegate
            {
                contx.SetPreference("profile.default_content_setting_values.plugins", 1, out string err1);
                contx.SetPreference("plugins.run_all_flash_in_allow_mode", true, out string err2);
            });
        }
        static void consoleWriter_WriteLineEvent(object sender, ConsoleWriterEventArgs e)
        {
            if(console!= null)
            {
                console.Text += e.Value + "\n";
            }
        }

        static void consoleWriter_WriteEvent(object sender, ConsoleWriterEventArgs e)
        {
            if (console != null)
            {
                console.Text += e.Value + "\n";
            }
        }

    }
}
