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
            this.moviePanel = new System.Windows.Forms.TableLayoutPanel();
            this.libRefresh = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dirLink = new MetroFramework.Controls.MetroLink();
            this.chDir = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // moviePanel
            // 
            resources.ApplyResources(this.moviePanel, "moviePanel");
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.moviePanel_Paint);
            // 
            // libRefresh
            // 
            resources.ApplyResources(this.libRefresh, "libRefresh");
            this.libRefresh.Name = "libRefresh";
            this.libRefresh.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click_1);
            // 
            // dirLink
            // 
            resources.ApplyResources(this.dirLink, "dirLink");
            this.dirLink.Name = "dirLink";
            this.dirLink.Click += new System.EventHandler(this.dirLink_Click);
            // 
            // chDir
            // 
            resources.ApplyResources(this.chDir, "chDir");
            this.chDir.Name = "chDir";
            this.chDir.Click += new System.EventHandler(this.chDir_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chDir);
            this.Controls.Add(this.dirLink);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.libRefresh);
            this.Controls.Add(this.moviePanel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel moviePanel;
        private MetroFramework.Controls.MetroButton libRefresh;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink dirLink;
        private MetroFramework.Controls.MetroButton chDir;
    }
}

