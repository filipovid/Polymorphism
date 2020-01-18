using AnimalFarm.FoodModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Factories
{
    public class FoodFactory
    {
        public static Food GenerateFood(string[] foodInfo)
        {
            string type = foodInfo[0].ToLower();
            int quantity = int.Parse(foodInfo[1]);

            switch(type)
            {
                case "meat":
                    return new Meat();

                case "vegetable":
                    return new Vegetable(quantity);

                default:
                    return null;
            }
        }
    }
}
