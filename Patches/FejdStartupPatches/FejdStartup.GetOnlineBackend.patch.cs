using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.FejdStartupPatches
{
    public static class FejdStartupGetOnlineBackendPatch
    {
        [HarmonyPatch(typeof(FejdStartup), nameof(FejdStartup.GetOnlineBackend))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(bool crossplayServer, ref OnlineBackendType __result)
            {
                __result = crossplayServer ? OnlineBackendType.None : OnlineBackendType.Steamworks;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}