using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.ZPlayFabMatchmakingPatches
{
    public static class ZPlayFabMatchmakingJoinCodePatch
	{
        [HarmonyPatch(typeof(ZPlayFabMatchmaking), nameof(ZPlayFabMatchmaking.JoinCode), MethodType.Getter)]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ref string __result)
            {
                __result = string.Empty;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
