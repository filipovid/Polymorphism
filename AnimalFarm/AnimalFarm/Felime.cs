using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public abstract class Felime : Mammal
    {
        public Felime(string name, string type, int weight, string region)
            : base(name, type, weight, region)
        {

        }
    }
}
