namespace Movie_Lib
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.moviePanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // moviePanel
            // 
            resources.ApplyResources(this.moviePanel, "moviePanel");
            this.moviePanel.HorizontalScrollbar = true;
            this.moviePanel.HorizontalScrollbarBarColor = true;
            this.moviePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.moviePanel.HorizontalScrollbarSize = 10;
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.VerticalScrollbar = true;
            this.moviePanel.VerticalScrollbarBarColor = true;
            this.moviePanel.VerticalScrollbarHighlightOnWheel = false;
            this.moviePanel.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moviePanel);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel moviePanel;
    }
}

