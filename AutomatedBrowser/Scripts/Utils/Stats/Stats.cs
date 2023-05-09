
using System.Collections.Generic;


namespace AutomatedBrowser.Scripts.Utils.Stats
{
    public class Stats
    {
        private ScriptForm form;
        private Dictionary<string, StatGroup> statGroups;
        
        public Stats(ScriptForm form) {
            this.form = form;
            StatGroup statGroup = new StatGroup(form.statsTabPage, "Stats");
            statGroups["default"] = statGroup;
        }
        
        private void CreateGroup(string name, string group = "default")
        {
            StatGroup statGroup = new StatGroup(statGroups[group].GetGroupBox(), name);
            statGroups[name] = statGroup;
        }
        public void CreateField(string name,string group = "default")
        {
            
            if (group != "default")
            {
                CreateGroup(group, "default");
            }
            statGroups[group].CreateField(name);

        }

        public void UpdateField(string group, string name,string value) {
            statGroups[group].SetFieldValue(name,value);
        }

    }
}
