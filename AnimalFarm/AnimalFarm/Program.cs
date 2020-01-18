using AnimalFarm.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                string[] animalInfo = input.Split();
                Animal animal = AnimalFactory.GenerateAnimal(animalInfo);

                string[] foodInfo = Console.ReadLine().Split();
                Food food = FoodFactory.GenerateFood(foodInfo);

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine(input);

                input = Console.ReadLine();

                Console.ReadLine();
            }
        }
    }
}
