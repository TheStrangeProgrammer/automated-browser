namespace AutomatedBrowser
{
    partial class Main
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
            this.toggleBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toggleBrowser
            // 
            this.toggleBrowser.Location = new System.Drawing.Point(585, 302);
            this.toggleBrowser.Name = "toggleBrowser";
            this.toggleBrowser.Size = new System.Drawing.Size(89, 23);
            this.toggleBrowser.TabIndex = 0;
            this.toggleBrowser.Text = "Toggle Browser";
            this.toggleBrowser.UseVisualStyleBackColor = true;
            this.toggleBrowser.Click += new System.EventHandler(this.ToggleBrowser_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.toggleBrowser);
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toggleBrowser;
    }
}

