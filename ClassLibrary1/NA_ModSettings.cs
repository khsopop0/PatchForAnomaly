using UnityEngine;
using Verse;
using System.Collections.Generic;

namespace NA_ModSettings
{
    public class NA_ModSettings : ModSettings
    {
        public Dictionary<string, Patch_Serum> serumDictionary;
        public class CostList
        {
            public ThingDef item;
            public int value;
            public CostList(string item, int value) {
                this.item = ThingDef.Named(item);
                this.value = value;
            }
        }
        public class Patch_Serum
        {
            //(Bioferrite, 30)("Neutroamine", 2)
            public string itemName;
            public List<CostList> costList = new List<CostList>();
            public int marketValue = 80;
            Patch_Serum()
            {

            }
        }

        public override void ExposeData()
        {

        }
    }
    
}
