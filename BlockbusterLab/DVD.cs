using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string title, string category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }
        public DVD(string title, string category, int runtime) : base(title, category, runtime)
        {

        }
        public override void Play()
        {
            try
            {

                PrintScenes();
                Console.WriteLine("Using the index 0 - 2, please select a scene you'd like to watch");
                int input = 0;
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Using the index 0 - 2, please select a scene you'd like to watch");
                }

                string scene = Scenes[input];
                Console.WriteLine(scene);
            }
            catch { Play(); }
        }
    }
}
