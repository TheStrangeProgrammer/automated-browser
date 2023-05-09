using CefSharp;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace AutomatedBrowser.Scripts.Utils
{
    public class UI
    {
        private Dictionary<string, Browser> browsers;
        private ScriptForm scriptForm;
        public UI() {
            browsers = new Dictionary<string, Browser>();   
            scriptForm = new ScriptForm();
            scriptForm.Show();
        }
        public Browser CreateBrowser(string name)
        {
            Browser browser = new Browser(name);
            browsers.Add(name, browser);
            scriptForm.browserListBox.Items.Add(name);
            browsers = new Dictionary<string, Browser>();
            return browser;
        }
        public GroupBox CreateGroup(string name)
        {
            return null;
        }
        public Label CreateLabel(string name)
        {
            return null;
        }
        public void CreateField(string name)
        {

        }
        public Button CreateButton(string name,EventHandler handler)
        {
            Button button = new Button();
            button.Click += handler;
            scriptForm.Controls.Add(button);
            return button;
        }
        public void ConsoleWriteLine(String text)
        {
            scriptForm.console.Text += text + "\n";
        }
    }
}
