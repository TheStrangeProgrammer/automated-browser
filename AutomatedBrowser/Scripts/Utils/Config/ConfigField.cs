using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedBrowser.Scripts.Utils.UI
{
    public class ConfigField
    {
        private Label nameLabel;
        private TextBox valueTextBox;
        public ConfigField(GroupBox group, string name, int y)
        {
            nameLabel = new Label();
            valueTextBox = new TextBox();
            //value.Width = 35;
            //value.Height = 13;
            nameLabel.Location = new Point(10, y);
            valueTextBox.Location = new Point(100, y);
            valueTextBox.
            nameLabel.Text = name + ":";

            group.Controls.Add(nameLabel);
            group.Controls.Add(valueTextBox);
        }
        public void SetName(string name)
        {
            nameLabel.Text = name + ":";
        }
        public void SetValue(string value)
        {
            valueTextBox.Text = value;
        }
        public string GetString()
        {
            return valueTextBox.Text;
        }
        public string GetInt()
        {
            return valueTextBox.Text;
        }
    }
}
