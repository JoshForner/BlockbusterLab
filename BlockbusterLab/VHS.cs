using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string title, string category, int runtime, List<string> scenes): base(title, category, runtime, scenes)
        {

        }
        public VHS(string title, string category, int runtime) : base(title, category, runtime)
        {

        }

        public override void Play()
        {
            try
            {

            string scene = Scenes[CurrentTime];
            Console.WriteLine(scene);
            CurrentTime++;
                if(CurrentTime >= Scenes.Count)
                {
                    Console.WriteLine("Rewinding and starting over");
                }
            }
            catch { Rewind(); Play(); }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
