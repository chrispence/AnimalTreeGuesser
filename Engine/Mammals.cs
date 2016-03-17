using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Mammals
    {
        public string Name { get; set; }
        public bool Large { get; set; }
        public bool Small { get; set; }
        
        public Mammals(string name, bool large, bool small)
        {
            Name = name;
            Large = large;
            Small = small;
        }

    }
}
