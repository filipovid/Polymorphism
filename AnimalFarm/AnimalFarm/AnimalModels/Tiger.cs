using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.AnimalModels
{
    public class Tiger : Mammal
    {
        public Tiger(string name, string type, int weight, string region)
            : base(name, type, weight, region)
        {

        }

        public override string MakeSound()
        {
            return "Roaaaar";
        }

        public override void Eat(Food food)
        {
            if (!food.GetType().Name.Equals("Meat"))
            {
                throw new ArgumentException($"{GetType().Name} are not eating that type of food");
            }

            base.Eat(food);
        }
    }
}
