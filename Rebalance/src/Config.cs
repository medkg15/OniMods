using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeterHan.PLib.Options;
using Newtonsoft.Json;

namespace Rebalance
{
    [JsonObject(MemberSerialization.OptIn)]
    public partial class Config
    {
        private const string PowerGeneratorCategory = "Generators";
        private const string PowerUsageCategory = "Power Usage";
        private const string StorageCapacityCategory = "Storage Capacity";
        private const string Electrolyzer = "Electrolyzer";
        private const string IncubatorCategory = "Incubator";
        private const string DecorCategory = "Decor";
        private const string RoomsCategory = "Rooms";
        private const string FoodCategory = "Food";
        private const string DuplicantCategory = "Duplicant";

        private static Lazy<Config> _instance = new Lazy<Config>(() => POptions.ReadSettings<Config>() ?? new Config());

        public static Config Instance => _instance.Value;
    }
}
