using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public abstract class Animal
    {
        private string _name;
        private string _type;
        private double _weight;
        private int _foodEaten;

        public Animal(string name, string type, double weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
        }

        protected string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        protected double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        protected int FoodEaten
        {
            get { return _foodEaten; }
            set { _foodEaten = value; }
        }

        public abstract string MakeSound();

        public virtual void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{GetType().Name}[{Name}, {Weight}, {FoodEaten}]";
        }
    }
}
