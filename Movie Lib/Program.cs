using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Lib
{
       
    public class Movie
    {
        public String name;
        public String released;
        public String runtime;
        public String genre;
        public String director;
        public String actors;
        public String plot;
        public String awards;
        public System.Drawing.Image poster;
        public int metascore;
        public double imdbRating;
        public int imdbId;
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            GetFiles(@"D:\Downloads");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }


        public static List<String> GetFiles(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            DirectoryInfo[] folders = d.GetDirectories();

            List<String> movies = new List<string>();

            foreach (DirectoryInfo dir in folders)
            {
                //Console.WriteLine(dir.FullName);

                String name = trimTitle(dir.Name);
                Console.WriteLine(dir.Name + " --> " + name);
            }
               
            return movies;

        }

        private static Movie getMovieData(String title)
        {
            Movie movie = new Movie();

            title = trimTitle(title);
            
            return movie;
        }

        private static string trimTitle(string title)
        {
            title = title.Replace("(", string.Empty).Replace(")", string.Empty).Replace("[", string.Empty).Replace("]", string.Empty);
            string[] strArr = title.Split('.', ' ');
            int index = 0;
            int year = 0;
            foreach (String s in strArr)
            {
                bool isNumeric = int.TryParse(s, out year);
                if (isNumeric && year > 1900 && index > 0) {
                    index++;
                    break;
                };
                index++;
            }
            if (year > 0)
            {
                index--;
            }
            String[] ret = new String[index];
            Array.Copy(strArr, 0, ret, 0, index);

            return string.Join(" ", ret);
        }
    }
}
