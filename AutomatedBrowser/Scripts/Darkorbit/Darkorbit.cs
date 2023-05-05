using AutomatedBrowser;
using AutomatedBrowser.Scripts;
using AutomatedBrowser.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;


    public class Darkorbit : Script
    {
        private BrowserForm mainBrowser;
        private BrowserForm gameBrowser;
        public Darkorbit()
        {
            
        }
        public override void Start()
        {
            Console.WriteLine("works");
        }
        public override void Init(MainForm mainForm)
        {
            base.Init(mainForm);
            mainBrowser = new BrowserForm();
            mainBrowser.Show();
            mainBrowser.Hide();
            gameBrowser = new BrowserForm();
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
        public override void Loop()
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
