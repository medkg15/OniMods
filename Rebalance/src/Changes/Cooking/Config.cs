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
        [Option("Electric Grill Power", "Electric Grill power consumption.  Original: 60w", PowerUsageCategory)]
        [JsonProperty]
        public float ElectricGrillPower { get; set; } = 120f; // higher?

        [Option("Microbe Musher Power", "Microbe Musher power consumption.  Original: 240w", PowerUsageCategory)]
        [JsonProperty]
        public float MicrobeMusherPower { get; set; } = 240f; // i don't feel strongly that the original is too high

        [Option("Food Quality BBQ", "Food Quality for BBQ.  Original: 3", PowerUsageCategory)]
        [JsonProperty]
        public int FoodQualityBbq { get; set; } = 2;
    }
}
