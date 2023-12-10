using HarmonyLib;
using Model.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterConductor.Patches
{
    [HarmonyPatch(typeof(AutoEngineerPlanner), "Search")]
    internal class AutoEngineerPATCH
    {
        [HarmonyPostfix]
        static void shortFusePatch(ref float? nextFlareDistance)
        {
            if (nextFlareDistance.HasValue)
            {
                nextFlareDistance += 16;
            }
        }
    }
}
