using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.FejdStartupPatches
{
    public static class FejdStartupAwakePlayFabPatch
    {
        [HarmonyPatch(typeof(FejdStartup), nameof(FejdStartup.AwakePlayFab))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ref bool __result)
            {
                PlayFabManager.Initialize();
                __result = true;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
