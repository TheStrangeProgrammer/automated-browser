using AutomatedBrowser.Scripts;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedBrowser
{
    public partial class Main : Form
    {
        
        private Timer scriptLoopTimer;
        private Script script;
        private Darkorbit darkorbitScript;
        public Main()
        {
            
            InitializeComponent();
            

            scriptLoopTimer = new Timer();
            scriptLoopTimer.Interval = 1000 / 30; //30 frames
            scriptLoopTimer.Tick += ScriptLoop_Tick;

            darkorbitScript = new Darkorbit();

            script = darkorbitScript;
        }
        private void ScriptLoop_Tick(object sender, EventArgs e)
        {
            script.Run();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            scriptLoopTimer.Start();
            darkorbitScript.Init(console);
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
