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
        [Option("Gas Reservoir Capacity", "Gas Reservoir Capacity.  Original: 150kg", StorageCapacityCategory)]
        [JsonProperty]
        public float GasReservoirCapacity { get; set; } = 1_000f;

        [Option("Liquid Reservoir Capacity", "Liquid Reservoir Capacity.  Original: 5t", StorageCapacityCategory)]
        [JsonProperty]
        public float LiquidReservoirCapacity { get; set; } = 15_000f;
    }
}
