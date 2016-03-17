using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class AquaticAnimals
    {
        public string Name { get; set; }
        public bool Shell { get; set; }
        public bool Large { get; set; }
        public bool Small { get; set; }
        
        public AquaticAnimals(string name, bool shell, bool large, bool small)
        {
            Name = name;
            Shell = shell;
            Large = large;
            Small = small;
        }
    }
}
