namespace AutomatedBrowser
{
    partial class ScriptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.console = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.browserTabPage = new System.Windows.Forms.TabControl();
            this.configTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.viewBrowser = new System.Windows.Forms.Button();
            this.browserListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statsTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.browserTabPage.SuspendLayout();
            this.configTabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.Location = new System.Drawing.Point(3, 3);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(252, 420);
            this.console.TabIndex = 0;
            this.console.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.console);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.browserTabPage);
            this.splitContainer1.Size = new System.Drawing.Size(776, 426);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 1;
            // 
            // browserTabPage
            // 
            this.browserTabPage.Controls.Add(this.configTabPage);
            this.browserTabPage.Controls.Add(this.tabPage2);
            this.browserTabPage.Controls.Add(this.statsTabPage);
            this.browserTabPage.Location = new System.Drawing.Point(3, 31);
            this.browserTabPage.Name = "browserTabPage";
            this.browserTabPage.SelectedIndex = 0;
            this.browserTabPage.Size = new System.Drawing.Size(508, 392);
            this.browserTabPage.TabIndex = 0;
            // 
            // configTabPage
            // 
            this.configTabPage.Controls.Add(this.label1);
            this.configTabPage.Location = new System.Drawing.Point(4, 22);
            this.configTabPage.Name = "configTabPage";
            this.configTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.configTabPage.Size = new System.Drawing.Size(500, 366);
            this.configTabPage.TabIndex = 0;
            this.configTabPage.Text = "Config";
            this.configTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.viewBrowser);
            this.tabPage2.Controls.Add(this.browserListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Browsers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // viewBrowser
            // 
            this.viewBrowser.Location = new System.Drawing.Point(401, 326);
            this.viewBrowser.Name = "viewBrowser";
            this.viewBrowser.Size = new System.Drawing.Size(93, 23);
            this.viewBrowser.TabIndex = 1;
            this.viewBrowser.Text = "View Browser";
            this.viewBrowser.UseVisualStyleBackColor = true;
            // 
            // browserListBox
            // 
            this.browserListBox.FormattingEnabled = true;
            this.browserListBox.Location = new System.Drawing.Point(6, 4);
            this.browserListBox.Name = "browserListBox";
            this.browserListBox.Size = new System.Drawing.Size(488, 316);
            this.browserListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // statsTabPage
            // 
            this.statsTabPage.AutoScroll = true;
            this.statsTabPage.Location = new System.Drawing.Point(4, 22);
            this.statsTabPage.Name = "statsTabPage";
            this.statsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statsTabPage.Size = new System.Drawing.Size(500, 366);
            this.statsTabPage.TabIndex = 2;
            this.statsTabPage.Text = "Stats";
            this.statsTabPage.UseVisualStyleBackColor = true;
            // 
            // ScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ScriptForm";
            this.Text = "ScriptForm";
            this.Load += new System.EventHandler(this.ScriptForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.browserTabPage.ResumeLayout(false);
            this.configTabPage.ResumeLayout(false);
            this.configTabPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl browserTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage configTabPage;
        public System.Windows.Forms.Button viewBrowser;
        public System.Windows.Forms.RichTextBox console;
        public System.Windows.Forms.ListBox browserListBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabPage statsTabPage;
    }
}