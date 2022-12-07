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
        [Option("Coal Generator CO2 Rate", "Wood burner CO2 production rate.  Original: 20g/s", PowerGeneratorCategory)]
        [JsonProperty]
        public float CoalGeneratorCO2Rate { get; set; } = 0.120f;

        [Option("Wood Burner Power", "Wood burner power production.  Original: 300w", PowerGeneratorCategory)]
        [JsonProperty]
        public float WoodBurnerPower { get; set; } = 300f;

        [Option("Wood Burner Heat", "Wood burner heat production.  Original: +9kDTU/s", PowerGeneratorCategory)]
        [JsonProperty]
        public float WoodBurnerHeat { get; set; } = 5f;

        [Option("Wood Burner Consumption Rate", "Wood burner wood consumption rate.  Original: 1.2kg/s", PowerGeneratorCategory)]
        [JsonProperty]
        public float WoodBurnerConsumptionRate { get; set; } = 0.75f;

        [Option("Wood Burner CO2 Rate", "Wood burner CO2 production rate.  Original: 170g/s", PowerGeneratorCategory)]
        [JsonProperty]
        public float WoodBurnerCO2Rate { get; set; } = 0.1f;
    }
}
