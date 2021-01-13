using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PeterHan.PLib;

namespace UiResize
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Config
    {
        [Option("Height Adjustment", "Extra height to be added to UI elements.")]
        [JsonProperty]
        public int HeightAdjustment { get; set; }

        public Config()
        {
            HeightAdjustment = 300;
        }
    }
}
