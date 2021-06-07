using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    interface IAutoPass
    {
        public string Body { get; set; }
        public string Color { get; set; }
        public int ReleasyYear { get; set; }
        public int MaxSpeed { get; set; }

    }
}
