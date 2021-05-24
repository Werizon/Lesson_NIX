using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Order
    {
        public List<Client> clients { get; set; }
        public List<Admin> sallers { get; set; }
        public List<Auto> autos { get; set; }
        public List<Services> services { get; set; }
    }
}
