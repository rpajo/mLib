using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Lib
{
    public partial class detailsControl : UserControl
    {
        public Movie movie;

        public detailsControl()
        {
            InitializeComponent();
        }

        public void setMovie ( Movie movie )
        {
            this.movie = movie;
            titleInput.Text = movie.name;
            titleLabel.Text = movie.name;
            releaseInput.Text = movie.released;
            actorInput.Text = movie.actors;
            genreInput.Text = movie.genre;
            directorInput.Text = movie.director;
            awardsInput.Text = movie.awards;
            runtimeInput.Text = movie.runtime;
            pictureBox1.ImageLocation = movie.posterUrl;
            imdbScore.Text = movie.imdbRating;
            metaScore.Text = movie.metascore;
            noVotes.Text = movie.imbdVotes;
            plotTextBox.Text = movie.plot;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["moviePanel"].Visible = true;
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
