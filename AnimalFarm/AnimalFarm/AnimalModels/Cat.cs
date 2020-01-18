using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.AnimalModels
{
    public class Cat : Felime
    {
        private string _breed;
        public Cat(string name, string type, int weight, string region, string breed)
            : base(name, type, weight, region)
        {
            Breed = breed;
        }

        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        public override string MakeSound()
        {
            return "Meowwwwww";
        }

        public override string ToString()
        {
            return $"{GetType().Name}[{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}";
        }
    }
}
