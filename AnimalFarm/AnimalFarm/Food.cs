using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public abstract class Food
    {
        private int _quantity;

        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
    }
}
