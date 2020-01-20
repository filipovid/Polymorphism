using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinedraftApp.Models.Providers
{
    public class PressureProvider : Provider
    {
        public PressureProvider(string id, double energyOutput)
            : base(id, energyOutput)
        {
            EnergyOutput *= 1.5;
        }
    }
}
