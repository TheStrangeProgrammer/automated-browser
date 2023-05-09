using AutomatedBrowser.Scripts;
using AutomatedBrowser.Utils;
using CefSharp;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
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
    public partial class MainForm : Form
    {
        
        
        private ScriptManager scriptManager;
        public MainForm()
        {          
            InitializeComponent();
            Program.console = console;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            scriptManager = new ScriptManager();

            RefreshScriptList();
        }

        private void RunScript_Click(object sender, EventArgs e) {
            scriptManager.RunScript((string)scriptListBox.SelectedItem);
        }
        private void StopScript_Click(object sender, EventArgs e)
        {

        }
        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshScriptList();
        }
        private void ScriptListBox_Selected(object sender, EventArgs e)
        {
            scriptManager.ScriptSelected();
        }
        private void RefreshScriptList()
        {
            scriptListBox.Items.Clear();
            scriptManager.FindScripts();
            foreach (string key in scriptManager.scriptDirs.Keys)
                scriptListBox.Items.Add(key);
        }
    }
}
