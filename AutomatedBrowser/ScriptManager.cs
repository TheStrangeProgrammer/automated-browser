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
using System.Timers;

namespace AutomatedBrowser.Utils
{

    internal class ScriptManager
    {
        public Dictionary<string, string> scriptDirs;
        public Dictionary<string, Script> compiledScripts;

        private Compiler compiler;
        public ScriptManager()
        {

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
                scriptDirs.Add(Path.GetFileName(dirString), dirString + "\\");
            }

        }

        public void CompileScript(string script)
        {

            JObject json = JObject.Parse(File.ReadAllText(scriptDirs[script] + "config.json"));
            //ConsoleLog.WriteLine((string)json.GetValue("startClass")+ scriptDirs[script]);
            if (!compiledScripts.ContainsKey(script))
            {
                compiledScripts[script] = compiler.Compile((string)json.GetValue("startClass"), scriptDirs[script]);
            }

        }
        public void ScriptSelected()
        {

        }
        public void LoadScript(string script)
        {
            if (!compiledScripts.ContainsKey(script))
            {
                JObject json = JObject.Parse(File.ReadAllText(scriptDirs[script] + "config.json"));
                compiledScripts[script] = compiler.Compile((string)json.GetValue("startClass"), scriptDirs[script]);
            }
            if (compiledScripts[script] == null)
            {
                compiledScripts.Remove(script);
            }
            else
            {
                compiledScripts[script].Init();
                //compiledScripts[script].Start();
            }
        }
        public void RunScript(string script)
        {
            //ConsoleLog.WriteLine((string)json.GetValue("startClass")+ scriptDirs[script]);
            if (!compiledScripts.ContainsKey(script))
            {
                JObject json = JObject.Parse(File.ReadAllText(scriptDirs[script] + "config.json"));
                compiledScripts[script] = compiler.Compile((string)json.GetValue("startClass"), scriptDirs[script]);
            }
            if (compiledScripts[script]==null)
            {
                compiledScripts.Remove(script);
            }
            else
            {
                compiledScripts[script].Init();
                compiledScripts[script].Start();
            }
            
        }
        public void StopScript(string script)
        {
            compiledScripts[script].Stop();
        }
    }
}
