using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedBrowser.Scripts
{
    public class Script
    {
        private int fps = 1000 / 30; // 1 second / 30 frames
        private MainForm mainForm;
        private RichTextBox console;
        private Timer scriptLoopTimer;
        private List<BrowserForm> browsers;
        private bool pauseScript;
        public Script()
        {
            browsers = new List<BrowserForm>();

            scriptLoopTimer = new Timer();
            scriptLoopTimer.Interval = fps; //30 frames
            scriptLoopTimer.Tick += ScriptLoop_Tick;

            pauseScript = true;
        }
        public BrowserForm CreateBrowser()
        {
            BrowserForm browser = new BrowserForm();
            browser.Show();
            browser.Hide();
            browsers.Add(browser);
            return browser;
        }
        private void ScriptLoop_Tick(object sender, EventArgs e)
        {
            if (!pauseScript)
            {
                this.Loop();
            }

        }
        public virtual void Init(MainForm mainForm)
        {
            this.mainForm = mainForm;
            console = mainForm.console;
            pauseScript = false;
            scriptLoopTimer.Start();
        }
        public virtual void Start()
        {

        }
        public virtual void Loop()
        {

        }
        public virtual void Pause()
        {
            pauseScript = true;
        }
        public virtual void Stop()
        {
            pauseScript = true;
            scriptLoopTimer.Stop();
        }
        public virtual void WriteLine(String text)
        {
            console.Text += text+ "\n";
        }
    }
}
