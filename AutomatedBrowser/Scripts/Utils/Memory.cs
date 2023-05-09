using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedBrowser.Scripts.Utils
{
    public class Memory
    {
        public void FindProcess()
        {
            Process.GetProcessesByName("test");
        }
    }
}
