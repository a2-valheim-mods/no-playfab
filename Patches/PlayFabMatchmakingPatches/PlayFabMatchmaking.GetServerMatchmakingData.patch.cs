#pragma warning disable IDE0060

using HarmonyLib;
using System;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabMatchmakingPatches
{
    public static class PlayFabMatchmakingGetServerMatchmakingDataPatch
    {
        [HarmonyPatch(typeof(PlayFabMatchmaking), nameof(PlayFabMatchmaking.GetServerMatchmakingData))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ref ServerMatchmakingData __result, ServerJoinData server, DateTime newerThanUtc)
            {
                __result = new ServerMatchmakingData(newerThanUtc.AddTicks(1L));
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}

#pragma warning restore IDE0060