using AnimalFarm.AnimalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Factories
{
    public class AnimalFactory
    {
        public static Animal GenerateAnimal(string[] animalInfo)
        {
            string type = animalInfo[0].ToLower();
            string name = animalInfo[1];
            int weight = int.Parse(animalInfo[2]);
            string region = animalInfo[3];

            switch (type)
            {
                case "mouse":
                    return new Mouse(name, type, weight, region);

                case "zebra":
                    return new Zebra(name, type, weight, region);

                case "cat":
                    string breed = animalInfo[4];
                    return new Cat(name, type, weight, region, breed);

                case "tiger":
                    return new Tiger(name, type, weight, region);

                default:
                    return null;
            }
        }
    }
}
