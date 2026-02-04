#pragma warning disable IDE0060

using HarmonyLib;
using Splatform;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabMatchmakingPatches
{
    public static class PlayFabMatchmakingIsPendingPatch
    {
        [HarmonyPatch(typeof(PlayFabMatchmaking), nameof(PlayFabMatchmaking.IsPending), typeof(ServerJoinData))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch1
        {
            public static bool Prefix(ref bool __result, ServerJoinData server)
            {
                __result = false;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }

        [HarmonyPatch(typeof(PlayFabMatchmaking), nameof(PlayFabMatchmaking.IsPending), typeof(PlatformUserID))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch2
        {
            public static bool Prefix(ref bool __result, PlatformUserID server)
            {
                __result = false;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}

#pragma warning restore IDE0060