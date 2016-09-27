﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Lib
{
       
    public class Movie
    {

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
                Console.WriteLine(dir.FullName);
                movies.Add(dir.Name);
            }
               
            return movies;

        }
    }
}