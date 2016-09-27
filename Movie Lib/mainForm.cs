using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Lib
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            List<Movie> movies = Movie_Lib.Program.GetFiles(@"D:/Downloads");

            int index = 0;
            foreach (Movie movie in movies)
            {
                addMovie(movie);
                index++;
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

        private void addMovie( Movie movie)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            try {
                movieControl movieFrame = new movieControl();
                String title = movie.name != null ? movie.name : movie.dir.Name;
                movieFrame.Controls[1].Text = title;
                moviePanel.Controls.Add(movieFrame);
                resources.ApplyResources(movieFrame, movie.dir.Name);
            }
            catch
            {

            }
            
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }

        private void moviePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
