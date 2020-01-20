using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinedraftApp.Models.Providers
{
    public class Provider : Identificator
    {
        private double _energyOutput;

        protected Provider(string id, double energyOutput)
            : base(id)
        {
            _energyOutput = energyOutput;
        }

        public double EnergyOutput
        {
            get { return _energyOutput; }
            set
            {
                if (value < 0 && value > 10000)
                {
                    throw new ArgumentException("EnergyOutput");
                }

                _energyOutput = value;
            }
        }
    }
}
