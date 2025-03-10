using HarmonyLib;
using RimWorld;
using Verse;
using System.Reflection;
using System.Linq;

namespace NA_Main
{
    [StaticConstructorOnStartup]
    public class NA_Main
    {
        public NA_Main()
        {

        }

    }

    public class NA_Patchs : DefModExtension
    {
        public static void ApplySettings()
        {
            foreach (var item in collection)
            {
                
            }
        }
    }
}
