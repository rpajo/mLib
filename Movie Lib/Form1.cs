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
            List<String> movies = Movie_Lib.Program.GetFiles(@"D:/Downloads");

            int index = 0;
            foreach (String name in movies)
            {
                addMovie(name, index);
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

        private void addMovie( String movie, int index )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            try {
                MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                tile.Size = new Size(178, 30);
                tile.Location = new Point(180*(index % 6), 300 * (index/6));
                
                tile.Text = movie;
                this.moviePanel.Controls.Add(tile);
                resources.ApplyResources(tile, "metroTile"+index);
            }
            catch
            {

            }
            
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
