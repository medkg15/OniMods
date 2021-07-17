using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PeterHan.PLib.Options;

namespace ResizeDuplicantManagementScreens
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Config
    {
        [Option("Height Adjustment", "Additional pixel height for Duplicant Management Screens.")]
        [JsonProperty]
        public int HeightAdjustment { get; set; }

        public Config()
        {
            HeightAdjustment = 300;
        }
    }
}
