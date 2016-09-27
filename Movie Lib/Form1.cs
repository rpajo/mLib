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
            for(int i = 0; i < 7; i++)
            {
                addMovie(i);
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

        private void addMovie( int i )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaa");
            // 
            // metroTile
            // 
            try {
                MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                tile.Location = new Point(120*i, 3);
                tile.Size = new Size(115, 30);
                tile.Text = "Movie no. " + i;
                this.moviePanel.Controls.Add(tile);
                resources.ApplyResources(tile, "metroTile"+i);
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
