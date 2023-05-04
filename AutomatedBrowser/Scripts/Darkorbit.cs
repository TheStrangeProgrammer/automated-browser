using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedBrowser.Scripts
{
    public class Darkorbit : Script
    {
        private Browser mainBrowser;
        private Browser gameBrowser;
        public Darkorbit() {
            
        }

        public override void Init(RichTextBox console)
        {
            base.Init(console);
            mainBrowser = new Browser();
            mainBrowser.Show();
            mainBrowser.Hide();
            gameBrowser = new Browser();
            gameBrowser.Show();
            gameBrowser.Hide();
            WriteLine("test");
        }
        public override void Run()
        {

        }
        private void ToggleGameBrowser_Click(object sender, EventArgs e)
        {
            if (mainBrowser.Visible) mainBrowser.Hide();
            else mainBrowser.Show();
        }
        private void ToggleMainBrowser_Click(object sender, EventArgs e)
        {
            if (gameBrowser.Visible) gameBrowser.Hide();
            else gameBrowser.Show();
        }
    }
}
