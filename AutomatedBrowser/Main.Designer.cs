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
            this.console = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(12, 12);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(281, 427);
            this.console.TabIndex = 1;
            this.console.Text = "";
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.console);
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox console;
    }
}

