
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;

namespace AutomatedBrowser.Scripts.Utils.Config
{
    internal class ConfigGroup
    {
        private GroupBox groupBox;
        private Dictionary<string, ConfigField> statFields;
        public ConfigGroup(TabPage tab, string name)
        {
            groupBox = new GroupBox();
            groupBox.Text = name;
            groupBox.Location = new Point(6, 6);
            groupBox.AutoSize = true;
            groupBox.Width = 488;
            groupBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            tab.Controls.Add(groupBox);
        }

        public ConfigGroup(GroupBox group, string name)
        {
            groupBox = new GroupBox();
            groupBox.Text = name;
            groupBox.Location = new Point(6, 6);
            groupBox.AutoSize = true;
            groupBox.Width = 473;
            groupBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            group.Controls.Add(groupBox);
        }

        public void CreateField(string name)
        {
            StatField statField = new StatField(groupBox, name, GetNextStatHeight());
            statFields[name] = statField;
        }
        public int GetNextStatHeight()
        {
            return (statFields.Count + 1) * 15;
        }
        public GroupBox GetGroupBox()
        {
            return groupBox;
        }
        public void SetFieldValue(string name, string value)
        {
            statFields[name].SetValue(value);
        }
    }
}
