using Verse;
using HarmonyLib;

namespace ArmoredFloors
{
    public class Mod : Verse.Mod
    {
        public Mod(ModContentPack content) : base(content)
        {
            new Harmony("the_codewarrior.rimworld.ArmoredFloors.main").PatchAll(); 
        }
    }
}
