using System.Drawing;
using System.Windows.Forms;


namespace AutomatedBrowser.Scripts.Utils.Stats
{
    public class StatField
    {
        private Label nameLabel;
        private Label valueLabel;
        public StatField(GroupBox group, string name, int y)
        {
            nameLabel = new Label();
            valueLabel = new Label();
            //value.Width = 35;
            //value.Height = 13;
            nameLabel.Location = new Point(10, y);
            valueLabel.Location = new Point(100, y);

            nameLabel.Text = name + ":";

            group.Controls.Add(nameLabel);
            group.Controls.Add(valueLabel);
        }
        public void SetName(string name)
        {
            nameLabel.Text = name + ":";
        }
        public void SetValue(string value)
        {
            valueLabel.Text = value;
        }
    }
}
