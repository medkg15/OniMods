using Database;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Rebalance.Changes.Rooms
{
    [HarmonyPatch(typeof(Db), nameof(Db.Initialize))]
    public class Db_Initialize_Patch
    {
        private static Dictionary<string, int> MoraleChanges => new Dictionary<string, int>()
        {
            {"EdibleMinus3", Config.Instance.FoodQualityMoraleNeg1 },
            {"EdibleMinus2", Config.Instance.FoodQualityMorale0 },
            {"EdibleMinus1", Config.Instance.FoodQualityMorale1 },
            {"Edible0", Config.Instance.FoodQualityMorale2 },
            {"Edible1", Config.Instance.FoodQualityMorale3 },
            {"Edible2", Config.Instance.FoodQualityMorale4 },
            {"Edible3", Config.Instance.FoodQualityMorale5 },

            //{"RoomBedroom", 3 },
            {"RoomMessHall", Config.Instance.MessHallMorale },
            {"RoomGreatHall", Config.Instance.GreatHallMorale },
            {"RoomPark", Config.Instance.ParkMorale },
            {"RoomNatureReserve", Config.Instance.NatureReserveMorale },

            //{"SodaFountain", 2 },
            //{"Juicer", 3 },
            //{"Danced", 3 },
            //{"PlayedArcade", 4 },
            //{"Sauna", 3 },
        };

        public static void Postfix()
        {
            var effects = Db.Get().effects;
            for (int i = 0; i < effects.Count; i++)
            {
                var effect = effects[i];
                Debug.Log($"{effect.Id}: {effect.Name}");
                if (MoraleChanges.ContainsKey(effect.Id))
                {
                    bool found = false;
                    foreach (var modifier in effect.SelfModifiers)
                    {
                        if (modifier.AttributeId == "QualityOfLife")
                        {
                            modifier.SetValue(MoraleChanges[effect.Id]);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Debug.Log($"Could not tweak effect \"{effect.Name}\" to have morale of +{MoraleChanges[effect.Id]}");
                    }
                }
            }
        }
    }
}
