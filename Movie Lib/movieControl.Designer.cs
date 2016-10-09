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
            this.posterDisp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.posterDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // tileText
            // 
            this.tileText.Location = new System.Drawing.Point(0, 3);
            this.tileText.Name = "tileText";
            this.tileText.Size = new System.Drawing.Size(197, 34);
            this.tileText.TabIndex = 0;
            this.tileText.Text = "Title";
            this.tileText.Click += new System.EventHandler(this.tileText_Click);
            // 
            // posterDisp
            // 
            this.posterDisp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.posterDisp.Location = new System.Drawing.Point(0, 39);
            this.posterDisp.Name = "posterDisp";
            this.posterDisp.Size = new System.Drawing.Size(197, 261);
            this.posterDisp.TabIndex = 1;
            this.posterDisp.TabStop = false;
            this.posterDisp.Click += new System.EventHandler(this.posterDisp_Click);
            // 
            // movieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.posterDisp);
            this.Controls.Add(this.tileText);
            this.Name = "movieControl";
            this.Size = new System.Drawing.Size(200, 300);
            ((System.ComponentModel.ISupportInitialize)(this.posterDisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileText;
        private System.Windows.Forms.PictureBox posterDisp;
    }
}
