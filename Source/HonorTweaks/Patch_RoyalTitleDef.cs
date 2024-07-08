using HarmonyLib;
using RimWorld;
using Verse;

namespace HonorTweaks
{
    [HarmonyPatch(typeof(RoyalTitleDef))]
    [HarmonyPatch("PostLoad")]
    public static class HonorCostPatch
    {
        public static void Postfix(RoyalTitleDef __instance)
        {
            Verse.Log.Message($"Patching favorCost for {__instance.defName}");
            if (HonorTweaksMod.settings != null)
            {
                switch (__instance.defName)
                {
                    case "Freeholder":
                        __instance.favorCost = HonorTweaksMod.settings.freeholderCost;
                        break;
                    case "Yeoman":
                        __instance.favorCost = HonorTweaksMod.settings.yeomanCost;
                        break;
                    case "Acolyte":
                        __instance.favorCost = HonorTweaksMod.settings.acolyteCost;
                        break;
                    case "Knight":
                        __instance.favorCost = HonorTweaksMod.settings.knightCost;
                        break;
                    case "Praetor":
                        __instance.favorCost = HonorTweaksMod.settings.praetorCost;
                        break;
                    case "Baron":
                        __instance.favorCost = HonorTweaksMod.settings.baronCost;
                        break;
                    case "Count":
                        __instance.favorCost = HonorTweaksMod.settings.countCost;
                        break;
                        // Add more cases for each title as needed
                }
            }
        }
    }
}
