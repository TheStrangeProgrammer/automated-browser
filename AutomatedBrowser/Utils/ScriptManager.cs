using AutomatedBrowser.Scripts;
using CefSharp.Internals;
using CefSharp.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedBrowser.Utils
{
    
    internal class ScriptManager
    {
        public Dictionary<string, string> scriptDirs;
        public Dictionary<string, Script> compiledScripts;
        private Compiler compiler;
        public ScriptManager() {

            scriptDirs = new Dictionary<string, string>();
            compiledScripts = new Dictionary<string, Script>();
            compiler = new Compiler();
            FindScripts();
        }  

        public void FindScripts()
        {
            scriptDirs = new Dictionary<string, string>();
            string[] dirStrings = Directory.GetDirectories(AppContext.BaseDirectory + "Scripts");
            foreach (string dirString in dirStrings)
            {
                scriptDirs.Add(Path.GetFileName(dirString), dirString+ "\\");
            }
            
        }

        public void CompileScript(string script)
        {

            JObject json = JObject.Parse(File.ReadAllText(scriptDirs[script]+"config.json"));
            //ConsoleLog.WriteLine((string)json.GetValue("startClass")+ scriptDirs[script]);
            compiledScripts[script] = compiler.Compile((string)json.GetValue("startClass"),scriptDirs[script]);
        }
        public void RunScript(string script)
        {

        }
    }
}
