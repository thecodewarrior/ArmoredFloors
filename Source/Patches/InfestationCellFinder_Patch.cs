using HarmonyLib;
using RimWorld;
using Verse;

namespace ArmoredFloors.Patches
{
    [HarmonyPatch(typeof(InfestationCellFinder), "GetScoreAt")]
    internal static class InfestationCellFinder_GetScoreAt_Patch
    {
        public static void Postfix(IntVec3 cell, Map map, ref float __result)
        {
            if (__result > 0f && map.terrainGrid.TerrainAt(cell).HasTag("InfestationBlocker"))
            {
                __result = 0f;
            }
        }
    }
}