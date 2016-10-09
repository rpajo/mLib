using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Movie_Lib
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            dirLink.Text = "D:/Downloads";
        }


        private void addMovie(Movie movie)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            try
            {
                movieControl movieFrame = new movieControl();
                movieFrame.movie = movie;
                String title = movie.name != null ? movie.name : movie.dir.Name;
                movieFrame.Controls[1].Text = title;
                Console.WriteLine(movieFrame.Controls[0].Name);
                PictureBox posterBox = (PictureBox)movieFrame.Controls[0];
                posterBox.ImageLocation = movie.posterUrl;
                posterBox.SizeMode = PictureBoxSizeMode.StretchImage;
                moviePanel.Controls.Add(movieFrame);
                resources.ApplyResources(movieFrame, movie.dir.Name);
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }



        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }

        private void moviePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            moviePanel.Controls.Clear();
            List<Movie> movies = Movie_Lib.Program.GetFiles(dirLink.Text);

            foreach (Movie movie in movies)
            {
                addMovie(movie);
            }
            Console.WriteLine("DONE!");
        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dirLink_Click(object sender, EventArgs e)
        {
            Process.Start(dirLink.Text);
        }

        private void chDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                //System.Windows.Forms.MessageBox.Show("Dir selected: " + fbd.SelectedPath);
                dirLink.Text = fbd.SelectedPath;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
