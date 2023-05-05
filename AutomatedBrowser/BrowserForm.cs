using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools;
using System.Drawing.Imaging;
using System.IO;
using CefSharp.DevTools.Page;

namespace AutomatedBrowser
{
    public partial class BrowserForm : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public DevToolsClient chromeDevTools;
        public BrowserForm()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("about:blank");
            // Add it to the form and fill it to the form window.
            chromeBrowser.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
            Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            
        }
        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void OnIsBrowserInitializedChanged(object sender, EventArgs e)
        {
            chromeDevTools = chromeBrowser.GetDevToolsClient();
        }
        public async Task<Bitmap> GetScreenshot()
        {
 
            CaptureScreenshotResponse response = await chromeDevTools.Page.CaptureScreenshotAsync();
            return new Bitmap(new MemoryStream(response.Data));
            
        }
        public async void SaveScreenshotPng(string dir,string name)
        {

            CaptureScreenshotResponse response = await chromeDevTools.Page.CaptureScreenshotAsync();
            using (Image image = Image.FromStream(new MemoryStream(response.Data)))
            {
                image.Save(dir +name+ ".png", ImageFormat.Png);
            }
        }
    }
}
