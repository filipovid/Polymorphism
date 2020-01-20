using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinedraftApp.Models.Providers
{
    public class SolarProvider : Provider
    {
        public SolarProvider(string id, double energyOutput)
            : base(id, energyOutput)
        {

        }
    }
}
