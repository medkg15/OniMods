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
        [Option("Filter Power", "Gas, Liquid, Solid Filter power consumption.  Original: 120w", PowerUsageCategory)]
        [JsonProperty]
        public float FilterPower { get; set; } = 20f;
    }
}
