using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Reptiles
    {
        public string Name { get; set; }
        public bool Amphibian { get; set; }
        public bool Shell { get; set; }
        
        public Reptiles(string name, bool amphibian, bool shell)
        {
            Name = name;
            Amphibian = amphibian;
            Shell = shell;
        }
    }
}
