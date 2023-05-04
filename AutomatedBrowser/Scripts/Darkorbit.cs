using CefSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AutomatedBrowser.Scripts
{
    public class Darkorbit : Script
    {
        private Browser mainBrowser;
        private Browser gameBrowser;
        public Darkorbit()
        {

        }

        public override void Init(Main mainForm)
        {
            base.Init(mainForm);
            mainBrowser = new Browser();
            mainBrowser.Show();
            mainBrowser.Hide();
            gameBrowser = new Browser();
            gameBrowser.Show();
            gameBrowser.Hide();
            WriteLine("test");

            Button newButton = new Button
            {
                Text = "Created Button",
                Location = new Point(400, 400),
                Size = new Size(50, 100)

            };
            newButton.Click += screenshot_Click;
            mainForm.Controls.Add(newButton);
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
        private void screenshot_Click(object sender, EventArgs e)
        {
            //DrawControlToImage();
        }
        
    }
}
