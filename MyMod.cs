namespace OniModTemplate
{
    using System.Collections.Generic;
    using HarmonyLib;
    using KMod;

    public class MyMod : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
        }

        public override void OnAllModsLoaded(Harmony harmony, IReadOnlyList<Mod> mods)
        {
            base.OnAllModsLoaded(harmony, mods);
        }
    }
}