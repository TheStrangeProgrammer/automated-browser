using AutomatedBrowser.Scripts.Utils;
using AutomatedBrowser.Scripts.Utils.Stats;
using AutomatedBrowser.Utils;
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

        public Config config;
        public Memory memory;
        public Stats stats;
        public UI scriptUI;
        private Timer scriptLoopTimer;
        private int fps = 1000 / 30; // 1 second / 30 frames
        public Script()
        {

            scriptUI = new UI();

            scriptLoopTimer = new Timer();
            scriptLoopTimer.Interval = fps; //30 frames
            scriptLoopTimer.Tick += ScriptLoop_Tick;
        }

        
        public virtual void Init()
        {
            
        }
        public virtual async void Start()
        {

        }
        public virtual async void Loop()
        {

        }
        public virtual void Pause()
        {
            
        }
        public virtual void Stop()
        {
            
            
        }
        private async void ScriptLoop_Tick(object sender, EventArgs e)
        {
            await Task.Run(() => Loop());
        }
    }
}
