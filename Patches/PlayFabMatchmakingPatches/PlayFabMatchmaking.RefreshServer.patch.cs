#pragma warning disable IDE0060

using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabMatchmakingPatches
{
    public static class PlayFabMatchmakingRefreshServerPatch
    {
        [HarmonyPatch(typeof(PlayFabMatchmaking), nameof(PlayFabMatchmaking.RefreshServer))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ref bool __result, ServerJoinData server, MatchmakingDataRetrievedHandler completedCallback)
            {
                __result = false;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}

#pragma warning restore IDE0060