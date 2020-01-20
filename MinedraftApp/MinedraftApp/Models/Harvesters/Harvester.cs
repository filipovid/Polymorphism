using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinedraftApp.Models.Harvesters
{
    public class Harvester : Identificator
    {
        private double _oreOutput;
        private double _energyRequirement;

        protected Harvester(string id, double oreOutput, double energyRequirement)
            : base(id)
        {
            _oreOutput = oreOutput;
            _energyRequirement = energyRequirement;
        }

        public double OreOutput
        {
            get { return _oreOutput; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("OreOutput");
                }

                _oreOutput = value;
            }
        }

        public double EnergyRequirement
        {
            get { return _energyRequirement; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("EnergyRequirement");
                }

                _energyRequirement = value;
            }
        }
    }
}
