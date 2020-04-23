using System;
using System.Collections.Generic;
using System.Text;

namespace lect14.task2
{
    class Neighbor
    {
        public string FullName { get; set; }
        public int FlatNumber { get; set; }
        public int PhoneNumber { get; set; }
        public List<Neighbor> floorNeighbors;
    }
}
