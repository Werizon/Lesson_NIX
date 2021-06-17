using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Engine
    {
        public string TypeEngine { get; set; }
        public string TypeFuel { get; set; }

        public Engine(string engine, string fuel)
        {
            TypeEngine = engine;
            TypeFuel = fuel;
        }
    }
}
