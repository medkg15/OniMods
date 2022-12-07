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
        [Option("Art Decor Boost", "Increase decor for art paintings.  Original: 5/10/15 (with 0 boost)", DecorCategory)]
        [JsonProperty]
        public int ArtDecorBoost { get; set; } = 5; // higher?

        [Option("Pixel Pack Decor", "Pixel Pack Decor.  Original: 20", DecorCategory)]
        [JsonProperty]
        public int PixelPackDecor { get; set; } = 5;

        [Option("Pixel Pack Decor Radius", "Pixel Pack Decor Radius.  Original: 4", DecorCategory)]
        [JsonProperty]
        public int PixelPackDecorRadius { get; set; } = 4;

        [Option("Decorative Plant Decor", "Decorative Plant Decor.  Original: 25", DecorCategory)]
        [JsonProperty]
        public int DecorativePlantDecor { get; set; } = 15;

        [Option("Decorative Plant Decor Radius", "Decorative Plant Decor Radius.  Original: 4", DecorCategory)]
        [JsonProperty]
        public int DecorativePlantDecorRadius { get; set; } = 4; //unchanged
    }
}
