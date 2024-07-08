using UnityEngine;
using Verse;

namespace HonorTweaks
{
    public class HonorTweaksSettings : ModSettings
    {
        public int freeholderCost = 1;
        public int yeomanCost = 6;
        public int acolyteCost = 6;
        public int knightCost = 8;
        public int praetorCost = 10;
        public int baronCost = 14;
        public int countCost = 20;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref freeholderCost, "freeholderCost", 1);
            Scribe_Values.Look(ref yeomanCost, "yeomanCost", 6);
            Scribe_Values.Look(ref acolyteCost, "acolyteCost", 6);
            Scribe_Values.Look(ref knightCost, "knightCost", 8);
            Scribe_Values.Look(ref praetorCost, "praetorCost", 10);
            Scribe_Values.Look(ref baronCost, "baronCost", 14);
            Scribe_Values.Look(ref countCost, "countCost", 20);
            base.ExposeData();
        }
    }
}
