namespace Movie_Lib
{
    partial class movieControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tileText = new MetroFramework.Controls.MetroTile();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tileText
            // 
            this.tileText.Location = new System.Drawing.Point(0, 3);
            this.tileText.Name = "tileText";
            this.tileText.Size = new System.Drawing.Size(197, 34);
            this.tileText.TabIndex = 0;
            this.tileText.Text = "Title";
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.imagePanel.Location = new System.Drawing.Point(0, 43);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(197, 254);
            this.imagePanel.TabIndex = 1;
            // 
            // movieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.tileText);
            this.Name = "movieControl";
            this.Size = new System.Drawing.Size(200, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileText;
        private System.Windows.Forms.Panel imagePanel;
    }
}
