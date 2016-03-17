using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class AnimalLibrary //Generate library of animals
    {
        public List<AquaticAnimals> ListAquaticAnimals = new List<AquaticAnimals>();
        public List<Insects> ListInsects = new List<Insects>();
        public List<Birds> ListBirds = new List<Birds>();
        public List<Reptiles> ListReptiles = new List<Reptiles>();
        public List<Mammals> ListMammals = new List<Mammals>();

        AnimalLibrary() //Method to populate library
        {
            PopulateAquaticAnimals();
            PopulateInsects();
            PopulateBirds();
            PopulateReptiles();
            PopulateMammals();
        }

        //Populate Aquatic
        private void PopulateAquaticAnimals()
        {
            ListAquaticAnimals.Add(new AquaticAnimals("Crab", true, false, true));
            ListAquaticAnimals.Add(new AquaticAnimals("Lobster", true, false, true));
            ListAquaticAnimals.Add(new AquaticAnimals("Dolphin", false, true, false));
            ListAquaticAnimals.Add(new AquaticAnimals("Shark", false, true, false));
            ListAquaticAnimals.Add(new AquaticAnimals("Whale", false, true, false));
            ListAquaticAnimals.Add(new AquaticAnimals("fish", false, false, true));
            ListAquaticAnimals.Add(new AquaticAnimals("JellyFish", false, false, true));
        }

        //Populate Insects
        private void PopulateInsects()
        {
            ListInsects.Add(new Insects("Butterfly", true, false));
            ListInsects.Add(new Insects("Spider", false, true));
            ListInsects.Add(new Insects("Roach", true, false));
            ListInsects.Add(new Insects("Mosquito", true, true));
        }

        //Populate Birds
        private void PopulateBirds()
        {
            ListBirds.Add(new Birds("Chicken", true));
            ListBirds.Add(new Birds("Duck", true));
            ListBirds.Add(new Birds("Quail", true));
            ListBirds.Add(new Birds("Common Bird", false));
            ListBirds.Add(new Birds("Eagle", false));
            ListBirds.Add(new Birds("Flamingo", false));
            ListBirds.Add(new Birds("Owl", false));
            ListBirds.Add(new Birds("Vulture", false));
        }

        //Populate Reptiles
        private void PopulateReptiles()
        {
            ListReptiles.Add(new Reptiles("Alligator", false, false));
            ListReptiles.Add(new Reptiles("Lizard", false, false));
            ListReptiles.Add(new Reptiles("Snake", false, false));
            ListReptiles.Add(new Reptiles("Frog", true, false));
            ListReptiles.Add(new Reptiles("Turtle", false, true));
        }

        //Populate Mammals
        private void PopulateMammals()
        {
            ListMammals.Add(new Mammals("Buffalo", true, false));
            ListMammals.Add(new Mammals("Bear", true, false));
            ListMammals.Add(new Mammals("Cow", true, false));
            ListMammals.Add(new Mammals("Elephant", true, false));
            ListMammals.Add(new Mammals("Giraffe", true, false));
            ListMammals.Add(new Mammals("Hippo", true, false));
            ListMammals.Add(new Mammals("Horse", true, false));
            ListMammals.Add(new Mammals("Lion", true, false));
            ListMammals.Add(new Mammals("Panda", true, false));
            ListMammals.Add(new Mammals("Rhino", true, false));
            ListMammals.Add(new Mammals("Zebra", true, false));
            ListMammals.Add(new Mammals("Cat", false, true));
            ListMammals.Add(new Mammals("Dog", false, true));
            ListMammals.Add(new Mammals("Deer", false, true));
            ListMammals.Add(new Mammals("Kangaroo", false, true));
            ListMammals.Add(new Mammals("Monkey", false, true));
            ListMammals.Add(new Mammals("Pig", false, true));
            ListMammals.Add(new Mammals("Rabbit", false, true));
            ListMammals.Add(new Mammals("Wolf", false, true));
        }

            
    }
}
