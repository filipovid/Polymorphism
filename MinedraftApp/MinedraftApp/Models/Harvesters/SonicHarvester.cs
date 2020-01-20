using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinedraftApp.Models.Harvesters
{
    public class SonicHarvester : Harvester
    {
        public int SonicFactor { get; set; }

        public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
            : base(id, oreOutput, energyRequirement / sonicFactor)
        {
            SonicFactor = sonicFactor;
        }
    }
}
