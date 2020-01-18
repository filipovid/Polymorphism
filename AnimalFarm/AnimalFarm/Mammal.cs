using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string name, string type, int weight, string region)
            : base(name, type, weight)
        {
            LivingRegion = region;
        }

        protected string LivingRegion
        {
            get { return _livingRegion; }
            set { _livingRegion = value; }
        }

        public override string ToString()
        {
            return $"{GetType().Name}[{Name}, {Weight}, {LivingRegion}, {FoodEaten}";
        }
    }
}
