using HarmonyLib;
using Verse;

namespace HonorTweaks
{
    [StaticConstructorOnStartup]
    internal static class HonorTweaksPatcher
    {
        static HonorTweaksPatcher()
        {
            var harmony = new Harmony("com.xavior.honortweaks");
            harmony.PatchAll();
        }
    }
}
