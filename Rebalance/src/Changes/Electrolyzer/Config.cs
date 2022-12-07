using Newtonsoft.Json;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalance
{
    public partial class Config
    {
        [Option("Electrolyzer Power", "Electrolyzer power consumption.  Original: 120w", Electrolyzer)]
        [JsonProperty]
        public float ElectrolyzerPower { get; set; } = 200f;

        [Option("Electrolyzer Oxygen Production", "Electrolyzer oxygen production.  Original: 888g/s", Electrolyzer)]
        [JsonProperty]
        public float ElectrolyzerOxygenProduction { get; set; } = 0.888f; //unchanged

        [Option("Electrolyzer Hydrogen Production", "Electrolyzer hydrogen production.  Original: 112g/s", Electrolyzer)]
        [JsonProperty]
        public float ElectrolyzerHydrogenProduction { get; set; } = 0.112f; //unchanged

        [Option("Electrolyzer Water Consumption", "Electrolyzer water consumption.  Original: 1kg/s", Electrolyzer)]
        [JsonProperty]
        public float ElectrolyzerWaterConsumption { get; set; } = 1f; //unchanged

        [Option("Electrolyzer Heat Production", "Electrolyzer Heat Production.  Original: 1.25kDTU/s", Electrolyzer)]
        [JsonProperty]
        public float ElectrolyzerHeatProduction { get; set; } = 3f;
    }
}
