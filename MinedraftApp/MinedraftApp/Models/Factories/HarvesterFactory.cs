using MinedraftApp.Models.Harvesters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinedraftApp.Models.Factories
{
    public class HarvesterFactory
    {
        public Harvester CreateHarvester(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];
            double oreOutput = double.Parse(arguments[2]);
            double energyRequirement = double.Parse(arguments[3]);

            switch(type)
            {
                case "Sonic":
                    int sonicFactory = int.Parse(arguments[4]);
                    return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactory);
                case "Hammer":
                    return new HammerHarvester(id, oreOutput, energyRequirement);
                default:
                    throw new ArgumentException("Invalid Harvester Type");
            }
        }
    }
}
