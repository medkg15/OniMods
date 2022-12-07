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
        [Option("Base Movement Speed", "Original: 0", DuplicantCategory)]
        [JsonProperty]
        public float MovementSpeedBase { get; set; } = 0.5f;

        [Option("Movement Speed Factor", "Original: 0.1", DuplicantCategory)]
        [JsonProperty]
        public float MovementSpeedFactor { get; set; } = 0.05f;
    }
}
