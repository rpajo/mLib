namespace Movie_Lib
{
    partial class detailsControl
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imdb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.released = new System.Windows.Forms.Label();
            this.runtime = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.Label();
            this.releaseInput = new System.Windows.Forms.Label();
            this.runtimeInput = new System.Windows.Forms.Label();
            this.genreInput = new System.Windows.Forms.Label();
            this.directorInput = new System.Windows.Forms.Label();
            this.actors = new System.Windows.Forms.Label();
            this.actorInput = new System.Windows.Forms.Label();
            this.awards = new System.Windows.Forms.Label();
            this.awardsInput = new System.Windows.Forms.Label();
            this.plotTextBox = new MetroFramework.Controls.MetroTextBox();
            this.back = new MetroFramework.Controls.MetroButton();
            this.imdbScore = new System.Windows.Forms.Label();
            this.metaScore = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.noVotes = new MetroFramework.Controls.MetroLabel();
            this.plot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 35);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Move Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 413);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imdb
            // 
            this.imdb.AutoSize = true;
            this.imdb.Location = new System.Drawing.Point(5, 482);
            this.imdb.Name = "imdb";
            this.imdb.Size = new System.Drawing.Size(100, 20);
            this.imdb.TabIndex = 8;
            this.imdb.Text = "Imdb Rating:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Metascore:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.plot);
            this.panel1.Controls.Add(this.noVotes);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metaScore);
            this.panel1.Controls.Add(this.imdbScore);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.plotTextBox);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.imdb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 619);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.titleInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.released, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.runtime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.genre, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.director, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.actors, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.awards, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.releaseInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.runtimeInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.genreInput, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.directorInput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.actorInput, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.awardsInput, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(344, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 413);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(61, 24);
            this.title.TabIndex = 0;
            this.title.Text = "TITLE";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // released
            // 
            this.released.AutoSize = true;
            this.released.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.released.Location = new System.Drawing.Point(3, 51);
            this.released.Name = "released";
            this.released.Size = new System.Drawing.Size(110, 24);
            this.released.TabIndex = 2;
            this.released.Text = "RELEASED";
            this.released.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.released.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // runtime
            // 
            this.runtime.AutoSize = true;
            this.runtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runtime.Location = new System.Drawing.Point(3, 102);
            this.runtime.Name = "runtime";
            this.runtime.Size = new System.Drawing.Size(95, 24);
            this.runtime.TabIndex = 3;
            this.runtime.Text = "RUNTIME";
            this.runtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genre.Location = new System.Drawing.Point(3, 153);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(77, 24);
            this.genre.TabIndex = 4;
            this.genre.Text = "GENRE";
            this.genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.director.Location = new System.Drawing.Point(3, 204);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(106, 24);
            this.director.TabIndex = 5;
            this.director.Text = "DIRECTOR";
            this.director.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleInput
            // 
            this.titleInput.AutoSize = true;
            this.titleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleInput.Location = new System.Drawing.Point(172, 0);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(60, 20);
            this.titleInput.TabIndex = 6;
            this.titleInput.Text = "label10";
            this.titleInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // releaseInput
            // 
            this.releaseInput.AutoSize = true;
            this.releaseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.releaseInput.Location = new System.Drawing.Point(172, 51);
            this.releaseInput.Name = "releaseInput";
            this.releaseInput.Size = new System.Drawing.Size(60, 20);
            this.releaseInput.TabIndex = 12;
            this.releaseInput.Text = "label16";
            this.releaseInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // runtimeInput
            // 
            this.runtimeInput.AutoSize = true;
            this.runtimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runtimeInput.Location = new System.Drawing.Point(172, 102);
            this.runtimeInput.Name = "runtimeInput";
            this.runtimeInput.Size = new System.Drawing.Size(60, 20);
            this.runtimeInput.TabIndex = 15;
            this.runtimeInput.Text = "label19";
            this.runtimeInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genreInput
            // 
            this.genreInput.AutoSize = true;
            this.genreInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genreInput.Location = new System.Drawing.Point(172, 153);
            this.genreInput.Name = "genreInput";
            this.genreInput.Size = new System.Drawing.Size(60, 20);
            this.genreInput.TabIndex = 18;
            this.genreInput.Text = "label22";
            this.genreInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // directorInput
            // 
            this.directorInput.AutoSize = true;
            this.directorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directorInput.Location = new System.Drawing.Point(172, 204);
            this.directorInput.Name = "directorInput";
            this.directorInput.Size = new System.Drawing.Size(60, 20);
            this.directorInput.TabIndex = 21;
            this.directorInput.Text = "label25";
            this.directorInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actors
            // 
            this.actors.AutoSize = true;
            this.actors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actors.Location = new System.Drawing.Point(3, 255);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(88, 24);
            this.actors.TabIndex = 24;
            this.actors.Text = "ACTORS";
            this.actors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actorInput
            // 
            this.actorInput.AutoSize = true;
            this.actorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actorInput.Location = new System.Drawing.Point(172, 255);
            this.actorInput.Name = "actorInput";
            this.actorInput.Size = new System.Drawing.Size(60, 20);
            this.actorInput.TabIndex = 25;
            this.actorInput.Text = "label29";
            this.actorInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // awards
            // 
            this.awards.AutoSize = true;
            this.awards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.awards.Location = new System.Drawing.Point(3, 306);
            this.awards.Name = "awards";
            this.awards.Size = new System.Drawing.Size(92, 24);
            this.awards.TabIndex = 28;
            this.awards.Text = "AWARDS";
            this.awards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // awardsInput
            // 
            this.awardsInput.AutoSize = true;
            this.awardsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.awardsInput.Location = new System.Drawing.Point(172, 306);
            this.awardsInput.Name = "awardsInput";
            this.awardsInput.Size = new System.Drawing.Size(60, 20);
            this.awardsInput.TabIndex = 29;
            this.awardsInput.Text = "label33";
            this.awardsInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.awardsInput.Click += new System.EventHandler(this.label33_Click);
            // 
            // plotTextBox
            // 
            this.plotTextBox.CustomBackground = true;
            this.plotTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.plotTextBox.Location = new System.Drawing.Point(756, 84);
            this.plotTextBox.Multiline = true;
            this.plotTextBox.Name = "plotTextBox";
            this.plotTextBox.ReadOnly = true;
            this.plotTextBox.Size = new System.Drawing.Size(290, 385);
            this.plotTextBox.TabIndex = 12;
            this.plotTextBox.Text = "metroTextBox1";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(3, 579);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(80, 37);
            this.back.TabIndex = 13;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // imdbScore
            // 
            this.imdbScore.AutoSize = true;
            this.imdbScore.Location = new System.Drawing.Point(104, 482);
            this.imdbScore.Name = "imdbScore";
            this.imdbScore.Size = new System.Drawing.Size(51, 20);
            this.imdbScore.TabIndex = 14;
            this.imdbScore.Text = "label1";
            // 
            // metaScore
            // 
            this.metaScore.AutoSize = true;
            this.metaScore.Location = new System.Drawing.Point(273, 482);
            this.metaScore.Name = "metaScore";
            this.metaScore.Size = new System.Drawing.Size(51, 20);
            this.metaScore.TabIndex = 15;
            this.metaScore.Text = "label2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 502);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Number of votes";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click_1);
            // 
            // noVotes
            // 
            this.noVotes.AutoSize = true;
            this.noVotes.Location = new System.Drawing.Point(123, 502);
            this.noVotes.Name = "noVotes";
            this.noVotes.Size = new System.Drawing.Size(83, 19);
            this.noVotes.TabIndex = 17;
            this.noVotes.Text = "metroLabel2";
            // 
            // plot
            // 
            this.plot.AutoSize = true;
            this.plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plot.Location = new System.Drawing.Point(756, 53);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(59, 24);
            this.plot.TabIndex = 30;
            this.plot.Text = "PLOT";
            this.plot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // detailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "detailsControl";
            this.Size = new System.Drawing.Size(1065, 619);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label imdb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label released;
        private System.Windows.Forms.Label runtime;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label titleInput;
        private System.Windows.Forms.Label releaseInput;
        private System.Windows.Forms.Label runtimeInput;
        private System.Windows.Forms.Label genreInput;
        private System.Windows.Forms.Label directorInput;
        private System.Windows.Forms.Label actors;
        private System.Windows.Forms.Label actorInput;
        private System.Windows.Forms.Label awards;
        private System.Windows.Forms.Label awardsInput;
        private MetroFramework.Controls.MetroTextBox plotTextBox;
        private MetroFramework.Controls.MetroButton back;
        private MetroFramework.Controls.MetroLabel noVotes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label metaScore;
        private System.Windows.Forms.Label imdbScore;
        private System.Windows.Forms.Label plot;
    }
}
