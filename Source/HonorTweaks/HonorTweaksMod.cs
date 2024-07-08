using UnityEngine;
using Verse;

namespace HonorTweaks
{
    public class HonorTweaksMod : Mod
    {
        public static HonorTweaksSettings settings;

        public HonorTweaksMod(ModContentPack content) : base(content)
        {
            settings = GetSettings<HonorTweaksSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard ls = new Listing_Standard();
            ls.Begin(inRect);

            ls.Label($"Freeholder Honor Cost: {settings.freeholderCost}");
            settings.freeholderCost = (int)ls.Slider(settings.freeholderCost, 0, 20);

            ls.Label($"Yeoman Honor Cost: {settings.yeomanCost}");
            settings.yeomanCost = (int)ls.Slider(settings.yeomanCost, 0, 20);

            ls.Label($"Acolyte Honor Cost: {settings.acolyteCost}");
            settings.acolyteCost = (int)ls.Slider(settings.acolyteCost, 0, 20);

            ls.Label($"Knight Honor Cost: {settings.knightCost}");
            settings.knightCost = (int)ls.Slider(settings.knightCost, 0, 20);

            ls.Label($"Praetor Honor Cost: {settings.praetorCost}");
            settings.praetorCost = (int)ls.Slider(settings.praetorCost, 0, 20);

            ls.Label($"Baron Honor Cost: {settings.baronCost}");
            settings.baronCost = (int)ls.Slider(settings.baronCost, 0, 20);

            ls.Label($"Count Honor Cost: {settings.countCost}");
            settings.countCost = (int)ls.Slider(settings.countCost, 0, 20);

            ls.End();
            base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return "Honor Tweaks";
        }
    }
}
