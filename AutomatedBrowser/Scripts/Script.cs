using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedBrowser.Scripts
{
    public class Script
    {
        RichTextBox console;
        public virtual void Init(RichTextBox console)
        {
            this.console = console;
        }
        public virtual void Run()
        {

        }
        public virtual void WriteLine(String text)
        {
            console.Text += text+ "\n";
        }
    }
}
