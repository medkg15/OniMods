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
    [HarmonyPatch(typeof(RoomType), MethodType.Constructor, new[] {
        typeof(string),
        typeof(string),
        typeof(string),
        typeof(string),
        typeof(string),
        typeof(RoomTypeCategory),
        typeof(RoomConstraints.Constraint),
        typeof(RoomConstraints.Constraint[]),
        typeof(RoomDetails.Detail[]),
        typeof(int),
        typeof(RoomType[]),
        typeof(bool),
        typeof(bool),
        typeof(string[]),
        typeof(int)
    })]
    class RoomTypes_Constructor_Patch
    {
        public static void Prefix(string id, ref RoomConstraints.Constraint[] additional_constraints)
        {
            if (id == nameof(RoomTypes.GreatHall) && Config.Instance.GreatHallLightRequired)
            {
                additional_constraints = additional_constraints.AddToArray(RoomConstraints.LIGHT);
            }
        }
    }
}
