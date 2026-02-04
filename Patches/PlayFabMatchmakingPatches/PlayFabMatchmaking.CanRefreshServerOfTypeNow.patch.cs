#pragma warning disable IDE0060

using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabMatchmakingPatches
{
    public static class PlayFabMatchmakingCanRefreshServerOfTypeNowPatch
    {
        [HarmonyPatch(typeof(PlayFabMatchmaking), nameof(PlayFabMatchmaking.CanRefreshServerOfTypeNow))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ref bool __result, ServerJoinDataType type)
            {
                __result = false;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}

#pragma warning restore IDE0060