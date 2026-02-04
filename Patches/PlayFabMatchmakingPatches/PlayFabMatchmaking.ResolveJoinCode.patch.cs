#pragma warning disable IDE0060

using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabMatchmakingPatches
{
    public static class PlayFabMatchmakingResolveJoinCodePatch
    {
        [HarmonyPatch(typeof(PlayFabMatchmaking), nameof(PlayFabMatchmaking.ResolveJoinCode))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(string joinCode, MatchmakingDataRetrievedHandler successCallback, ZPlayFabMatchmakingFailedCallback failedCallback)
            {
                if (failedCallback is not null)
                {
                    failedCallback(ZPLayFabMatchmakingFailReason.NotLoggedIn);
                }
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}

#pragma warning restore IDE0060