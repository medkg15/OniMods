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
        [Option("Mess Hall Morale", "Mess Hall Morale bonus.  Original: 3", RoomsCategory)]
        [JsonProperty]
        public int MessHallMorale { get; set; } = 1;

        [Option("Great Hall Morale", "Great Hall Morale bonus.  Original: 6", RoomsCategory)]
        [JsonProperty]
        public int GreatHallMorale { get; set; } = 3;

        [Option("Park Morale", "Park Morale bonus.  Original: 3", RoomsCategory)]
        [JsonProperty]
        public int ParkMorale { get; set; } = 1;

        [Option("Nature Reserve Morale", "Nature Reserve Morale bonus.  Original: 6", RoomsCategory)]
        [JsonProperty]
        public int NatureReserveMorale { get; set; } = 3;

        [Option("Food Quality Morale: -1", "Morale for Food Quality -1.  Original: -1", FoodCategory)]
        [JsonProperty]
        public int FoodQualityMoraleNeg1 { get; set; } = -1;

        [Option("Food Quality Morale: 0", "Morale for Food Quality 0.  Original: 0", FoodCategory)]
        [JsonProperty]
        public int FoodQualityMorale0 { get; set; } = 0;

        [Option("Food Quality Morale: 1", "Morale for Food Quality 1.  Original: 1", FoodCategory)]
        [JsonProperty]
        public int FoodQualityMorale1 { get; set; } = 1;

        [Option("Food Quality Morale: 2", "Morale for Food Quality 2.  Original: 4", FoodCategory)]
        [JsonProperty]
        public int FoodQualityMorale2 { get; set; } = 2;

        [Option("Food Quality Morale: 3", "Morale for Food Quality 3.  Original: 8", FoodCategory)]
        [JsonProperty]
        public int FoodQualityMorale3 { get; set; } = 4;

        [Option("Food Quality Morale: 4", "Morale for Food Quality 4.  Original: 12", FoodCategory)]
        [JsonProperty]
        public int FoodQualityMorale4 { get; set; } = 7;

        [Option("Food Quality Morale: 5", "Morale for Food Quality 5.  Original: 16", FoodCategory)]
        [JsonProperty]
        public int FoodQualityMorale5 { get; set; } = 10;
    }
}
