using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = Blockbuster.CheckOut();
            PlayMovie(choice);
        }

        public static bool Another()
        {
            while (true)
            {
            Console.WriteLine("Would you like another scene? y/n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    return true;
                }
                if(answer == "n")
                {
                    return false;
                }
            }
        }

        public static void PlayMovie(int choice)
        {
            List<string> vhsScenes = new List<string>();
            vhsScenes.Add("The sand Scene");
            vhsScenes.Add("The lot scene");
            vhsScenes.Add("The Baseball scene");
            List<string> vhsScenes2 = new List<string>();
            vhsScenes2.Add("Mom dies scene");
            vhsScenes2.Add("Bambi makes friends scene");
            vhsScenes2.Add("The end scene");
            List<string> vhsScenes3 = new List<string>();
            vhsScenes3.Add("Something scary scene");
            vhsScenes3.Add("Something else scary scene");
            vhsScenes3.Add("I think a guy chops through a door scene");
            VHS v = new VHS("The Sandlot", "Drama", 90, vhsScenes);
            VHS b = new VHS("Bambi", "Romance", 85, vhsScenes2);
            VHS ts = new VHS("The Shining", "Horror", 130, vhsScenes3);
            List<string> dvdScenes = new List<string>();
            dvdScenes.Add("Most annoying sound in the world");
            dvdScenes.Add("The scene where he got tounge stuck on an icy pole");
            dvdScenes.Add("The Pretty Bird Scene");
            List<string> dvdScenes2 = new List<string>();
            dvdScenes2.Add("Mom dies scene");
            dvdScenes2.Add("Nemo gets put in fish tank scene");
            dvdScenes2.Add("Shark meeting scene");
            List<string> dvdScenes3 = new List<string>();
            dvdScenes3.Add("Bruce Willis scene");
            dvdScenes3.Add("Something with a gun scene");
            dvdScenes3.Add("Bruce Willis wins scene");
            DVD dumdum = new DVD("Dumb and Dumber", "Comedy", 80, dvdScenes);
            DVD fn = new DVD("Finding Nemo", "Drama", 120, dvdScenes2);
            DVD dh = new DVD("Die Hard", "Action", 95, dvdScenes3);
            bool another = true;
            while (another)
            {
                if (choice == 1)
                {
                    v.Play();
                    another = Another();
                }
                if (choice == 2)
                {
                    b.Play();
                    another = Another();
                }
                if (choice == 3)
                {
                    ts.Play();
                    another = Another();
                }
                if (choice == 4)
                {
                    dumdum.Play();
                    another = Another();
                }
                if (choice == 5)
                {
                    fn.Play();
                    another = Another();
                }
                if (choice == 6)
                {
                    dh.Play();
                    another = Another();
                }
            }
        }
    }
}
