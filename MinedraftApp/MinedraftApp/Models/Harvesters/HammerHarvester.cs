using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinedraftApp.Models.Harvesters
{
    public class HammerHarvester : Harvester
    {
        public HammerHarvester(string id, double oreOutput, double energyRequirement)
            : base(id, oreOutput, energyRequirement)
        {
            OreOutput += oreOutput * 2;
            EnergyRequirement += energyRequirement;
        }
    }
}
