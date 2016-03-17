using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Insects
    {
        public string Name { get; set; }
        public bool Fly { get; set; }
        public bool Bite { get; set; }

        public Insects(string name, bool fly, bool bite)
        {
            Name = name;
            Fly = fly;
            Bite = bite;
        }
    }
}
