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
        Main mainForm;
        RichTextBox console;
        public virtual void Init(Main mainForm)
        {
            this.mainForm = mainForm;
            console = mainForm.console;
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
