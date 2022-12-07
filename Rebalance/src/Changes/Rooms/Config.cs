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
        [Option("Great Hall Light Required", "Great Hall light requirement.", RoomsCategory)]
        [JsonProperty]
        public bool GreatHallLightRequired { get; set; } = true;
    }
}
