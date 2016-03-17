using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Questions
    {
        public string TypeQuestion { get; set; }
        public string[] AnimalType = new string[]{ "Aquatic Animals", "Birds", "Insects", "Mammals", "Reptiles" };

    public Questions(string typeQuestion, string[] animalType)
        {
            TypeQuestion = typeQuestion;
            AnimalType = animalType;
        }
        
    }
}
