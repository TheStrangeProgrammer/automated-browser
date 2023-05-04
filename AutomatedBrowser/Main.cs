using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedBrowser
{
    public partial class Main : Form
    {
        private Browser browser;
        private Browser browser2;
        private Timer scriptLoopTimer;
        public Main()
        {
            
            InitializeComponent();
            browser = new Browser();
            browser.Show();
            browser.Hide();
            browser2 = new Browser();
            browser2.Show();

            scriptLoopTimer = new Timer();
            scriptLoopTimer.Interval = 1000 / 30; //30 frames
            scriptLoopTimer.Tick += ScriptLoop_Tick;
            
        }
        private void ScriptLoop_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("test");
        }
        private void Main_Load(object sender, EventArgs e)
        {
            scriptLoopTimer.Start();
        }

        private void ToggleBrowser_Click(object sender, EventArgs e)
        {
            if (browser.Visible) browser.Hide();
            else browser.Show();
        }
        private void ToggleScript_Click(object sender, EventArgs e)
        {
            if (scriptLoopTimer.Enabled) scriptLoopTimer.Stop();
            else scriptLoopTimer.Start();
        }
        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
