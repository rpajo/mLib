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
    public partial class movieControl : UserControl
    {
        public Movie movie;

        public movieControl()
        {
            InitializeComponent();
        }

        private void posterDisp_Click(object sender, EventArgs e)
        {
            openMovie();
        }

        private void tileText_Click(object sender, EventArgs e)
        {
            openMovie();
        }

        private void openMovie()
        {
            Console.WriteLine(this.Parent.Name);
            this.Parent.Visible = false;
            detailsControl detailPane = new detailsControl();
            detailPane.setMovie(movie);
            detailPane.Size = this.Parent.Size;
            detailPane.Location = this.Parent.Location;
            this.Parent.Parent.Controls.Add(detailPane);
            //resources.ApplyResources(detailPane, "Details");
        }
    }
}
