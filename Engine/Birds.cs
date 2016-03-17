using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Birds
    {
        public string Name { get; set; }
        public bool Cook { get; set; }
        
        public Birds(string name, bool cook)
        {
            Name = name;
            Cook = cook;
        }
    }
}
