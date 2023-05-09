using AutomatedBrowser.Scripts;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using CefSharp.DevTools.DOM;

namespace AutomatedBrowser.Utils
{
    public class Compiler
    {
        private CSharpCodeProvider provider;
        private CompilerParameters compilerParams;
        private Dictionary<string, string> providerOptions;

        public Compiler() {

            providerOptions = new Dictionary<string, string>
                {
                    {"CompilerVersion", "v4.0"}
                };
            provider = new CSharpCodeProvider(providerOptions);

            compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };
            //compilerParams.ReferencedAssemblies.Add();
            
        }

        public Scripts.Script Compile(string startClass,string dir)
        {

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateInMemory = true;
            //The next line is the addition to the original code


            parameters.ReferencedAssemblies.Add(Assembly.GetEntryAssembly().Location);
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Drawing.dll");
            parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            parameters.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            //Assembly.GetReferencedAssemblies().ToList();
            //parameters.ReferencedAssemblies.Add(.);
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, File.ReadAllText(dir + startClass + ".cs"));
            if (results.Errors.HasErrors)
            {
                foreach (CompilerError errors in results.Errors)
                {
                    Console.WriteLine(errors.FileName + errors.ErrorText);
                }
            }
            else
            {
                Assembly assembly = results.CompiledAssembly;
                Type program = assembly.GetType("Darkorbit");
                object compiledClass = assembly.CreateInstance(startClass);
                //((Scripts.Script)compiledClass).Start();
                return (Scripts.Script)compiledClass;
                //MethodInfo main = program.GetMethod("Start");
                //main.Invoke(null, null);

            }
            
            //CSharpScript.Eva
            //compilerParams.CompilerOptions += " /recurse:" + dir  + "*.cs";
            //ConsoleLog.WriteLine(dir  + startClass + ".cs");
            //var script = CSharpScript.Create(File.ReadAllText(dir + startClass + ".cs"), ScriptOptions.Default.WithReferences(Assembly.GetExecutingAssembly()));
            //script.Compile();
            //var testType = script.RunAsync().Result.ReturnValue;
            //var testClass = Activator.CreateInstance((Type)testType);
            //((Scripts.Script)testClass).Start();
            //CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, new string[1] { dir + startClass + ".cs" });

            //foreach (CompilerError errors in results.Errors) {
            //    ConsoleLog.WriteLine(errors.FileName+errors.ErrorText);
            //}
            //object compiledClass = results.CompiledAssembly.CreateInstance(startClass);
            //if (results.Errors.Count == 0)
            //{
            //object compiledClass = results.CompiledAssembly.CreateInstance(startClass);
            //Type mi = o.GetType();
            //return (Scripts.Script)compiledClass;
            //}
            return null;
            
        }
    }
}
