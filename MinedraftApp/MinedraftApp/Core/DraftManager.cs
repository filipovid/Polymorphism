using MinedraftApp.Enums;
using MinedraftApp.Models;
using MinedraftApp.Models.Factories;
using MinedraftApp.Models.Harvesters;
using MinedraftApp.Models.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinedraftApp.Core
{
    public class DraftManager
    {
        IList<Harvester> _harvesters;
        IList<Provider> _providers;
        HarvesterFactory _harvesterFactory;
        ProviderFactory _providerFactory;
        Mode _currentMode;
        double _totalStoredEnergy;
        double _totalMineOre;

        public DraftManager()
        {
            _harvesters = new List<Harvester>();
            _providers = new List<Provider>();
            _harvesterFactory = new HarvesterFactory();
            _providerFactory = new ProviderFactory();
            _currentMode = global::MinedraftApp.Enums.Mode.Full;
            _totalStoredEnergy = 0d;
            _totalStoredEnergy = 0d;
        }
        
        public string RegisterHarvester(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];

            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Harvester is not registered, because of {ex.Message}");
            }

            return $"Successfully registered {type} Harvester - {id}";
        }

        public string RegisterProvider(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];

            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Provider is not registered, because of {ex.Message}");
            }

            return $"Successfully registered {type} Provider - {id}";
        }

        public string Day()
        {
            double energy = this._providers.Sum(x => x.EnergyOutput);
            _totalStoredEnergy += energy;
            double energyRequiremenetSum = this._harvesters.Sum(x => x.EnergyRequirement);
            double minedOre = this._harvesters.Sum(x => x.OreOutput);

            if (this._currentMode == global::MinedraftApp.Enums.Mode.Half)
            {
                energyRequiremenetSum *= 0.6;
                minedOre *= 0.5;
            }

            if (_totalStoredEnergy >=  energyRequiremenetSum && this._currentMode != global::MinedraftApp.Enums.Mode.Energy)
            {
                this._totalMineOre += minedOre;
                _totalStoredEnergy -= energyRequiremenetSum;
            }
            else
            {
                minedOre = 0;
            }

            string output = "A day has passed.\n";
            output += $"Energy Provided: {energy}";
            output += $"Plumbus Ore Mined: {minedOre}";

            return output;
        }

        public string Mode(List<string> arguments)
        {
            string modeAsString = arguments[0];
            Enum.TryParse(modeAsString, out Mode mode);
            this._currentMode = mode;
            return $"Successfully changed working mode to {mode} Mode";
        }

        public string Check(List<string> arguments)
        {
            string id = arguments[0];
            Identificator element = (Identificator)this._harvesters.FirstOrDefault(x => x.Id == id)
                ?? this._providers.FirstOrDefault(p => p.Id == id);

            if (element != null)
            {
                return element.ToString();
            }

            return $"No element found with id - {id}";
        }

        public string ShutDown()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("System Shutdown");
            sb.AppendLine($"Total energy stored: {this._totalStoredEnergy}");
            sb.AppendLine($"Total Mine Plumbus Ore: {this._totalMineOre}");

            return sb.ToString().TrimEnd();
        }
    }
}
