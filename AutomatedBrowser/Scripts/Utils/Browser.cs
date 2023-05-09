using CefSharp.DevTools.Page;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp.WinForms;
using CefSharp.DevTools;
using CefSharp;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;

namespace AutomatedBrowser.Scripts.Utils
{
    public class Browser
    {
        
        private ChromiumWebBrowser chromeBrowser;
        private DevToolsClient chromeDevTools;

        private BrowserForm browserForm;

        public Browser(string name) {
            browserForm = new BrowserForm();
            browserForm.Text = name;
            InitializeChromium();
            browserForm.Show();
            browserForm.Hide();
            
        }
        private void InitializeChromium()
        {
            
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://www.y8.com/games/earn_to_die_2012_part_2");
            
            // Add it to the form and fill it to the form window.
            chromeBrowser.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
            browserForm.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            
        }
        private void OnIsBrowserInitializedChanged(object sender, EventArgs e)
        {
            chromeDevTools = chromeBrowser.GetDevToolsClient();
            
        }
        public void Navigate(string url)
        {
            chromeBrowser.Load(url);
        }
        public async void NavigateAsync(string url)
        {
            await chromeDevTools.Page.NavigateAsync(url);
        }
        public async Task<Bitmap> GetScreenshot()
        {

            CaptureScreenshotResponse response = await chromeDevTools.Page.CaptureScreenshotAsync();
            return new Bitmap(new MemoryStream(response.Data));

        }
        public async void SaveScreenshotPng(string dir, string name)
        {

            CaptureScreenshotResponse response = await chromeDevTools.Page.CaptureScreenshotAsync();
            using (Image image = Image.FromStream(new MemoryStream(response.Data)))
            {
                image.Save(dir + name + ".png", ImageFormat.Png);
            }
        }
        public void Display() {
            browserForm.Show();
        }
        public async Task<int> GetPID()
        {
            //NOTE Chromium will switch processes when performing cross origin navigations and you will end up with a different render process hosting your website.

            var response = await chromeBrowser.EvaluateScriptAsync("cefSharp.renderProcessId");
            if (response.Success)
            {
                return (int)response.Result;
            }
            return -1;
        }
    }
}
