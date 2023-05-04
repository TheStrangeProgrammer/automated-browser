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
    public partial class Browser : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public DevToolsClient chromeDevTools;
        public Browser()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://www.ultrasounds.com/");
            // Add it to the form and fill it to the form window.
            Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            chromeDevTools = chromeBrowser.GetDevToolsClient();
        }
        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        public async Task<Bitmap> GetScreenshot()
        {
 
            CaptureScreenshotResponse response = await chromeDevTools.Page.CaptureScreenshotAsync();
            return new Bitmap(new MemoryStream(response.Data));
            
        }
        public async void SaveScreenshot()
        {

            CaptureScreenshotResponse response = await chromeDevTools.Page.CaptureScreenshotAsync();
            using (Image image = Image.FromStream(new MemoryStream(response.Data)))
            {
                image.Save(@"D:\whatever.png", ImageFormat.Png);
            }
        }
    }
}
