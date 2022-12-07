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
        [Option("Lullabied Power Required", "Lullabied buff lost if Incubator is unpowered.", IncubatorCategory)]
        [JsonProperty]
        public bool LullabyPowerRequired { get; set; } = true;

        [Option("Incubator Power", "Incubator power consumption.  Original: 240w", Electrolyzer)]
        [JsonProperty]
        public float IncubatorPower { get; set; } = 60f;
    }
}
