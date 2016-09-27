using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

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
        public String posterUrl;
        public System.Drawing.Image poster;
        public String metascore;
        public String imdbRating;
        public String imdbId;
        public DirectoryInfo dir;

        public Movie() { }

        public Movie(JObject meta)
        {
            this.name = (string)meta["Title"];
            this.released = (string)meta["Released"];
            this.runtime = (string)meta["Runtime"];
            this.genre = (string)meta["Genre"];
            this.director = (string)meta["Director"];
            this.actors = (string)meta["Actors"];
            this.plot = (string)meta["Plot"];
            this.awards = (string)meta["Awards"];
            this.posterUrl = (string)meta["Poster"];
            this.metascore = (String)meta["Metascore"];
            this.imdbRating = (String)meta["imdbRating"];
            this.imdbId = (string)meta["imdbID"];
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //GetFiles(@"D:\Downloads");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }


        public static List<Movie> GetFiles(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            DirectoryInfo[] folders = d.GetDirectories();

            List<Movie> movies = new List<Movie>();

            foreach (DirectoryInfo dir in folders)
            {
                //Console.WriteLine(dir.FullName);

                //String name = trimTitle(dir.Name);
                //Console.WriteLine(dir.Name + " --> " + name);

                Movie movie = getMovieData(dir.Name);
                movie.dir = dir;
                movies.Add(movie);
                Console.WriteLine(":::" + movies.Last().name);
            }
               
            return movies;

        }

        private static Movie getMovieData(String title)
        {
            // time title
            title = trimTitle(title);

            // rest api setup
            string endPoint = "http://www.omdbapi.com/";
            var client = new RestClient(endPoint);
            var request = new RestRequest(Method.GET);
            request.AddParameter("t", title);
            IRestResponse response = client.Execute(request);
            JObject content = JObject.Parse(response.Content);

            //Console.WriteLine(content);
            //Console.WriteLine(response.StatusCode);

            Movie movie;
            Console.WriteLine(content["Response"]);

            movie = new Movie(content);


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
