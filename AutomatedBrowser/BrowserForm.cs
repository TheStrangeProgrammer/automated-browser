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

        public BrowserForm()
        {
            InitializeComponent();
        }

        
        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        
       
        private void BrowserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
