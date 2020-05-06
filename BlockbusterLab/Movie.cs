using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    public enum Category { Drama, Comedy, Horror, Romance, Action }
    abstract class Movie
    {
        public readonly Category category;
        public List<string> Scenes { get; set; }

        public string Title { get; set; }
        public int RunTime { get; set; }

        public Movie(string title, string cat, int runtime, List<string> scenes)
        {
            Title = title;
            RunTime = runtime;
            Scenes = scenes;
            category = (Category)Enum.Parse(typeof(Category), cat);
        }
        public Movie(string title, string cat, int runtime) 
        {
            Title = title;
            RunTime = runtime;
            category = (Category)Enum.Parse(typeof(Category), cat);
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i}. {Scenes[i]}");
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {category}");
            Console.WriteLine($"Runtime: {RunTime}");
        }

        public abstract void Play();
    }
}
