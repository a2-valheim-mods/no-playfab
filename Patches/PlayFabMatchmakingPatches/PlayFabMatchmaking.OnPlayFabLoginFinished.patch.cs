using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabMatchmakingPatches
{
    public static class PlayFabMatchmakingOnPlayFabLoginFinishedPatch
    {
        [HarmonyPatch(typeof(PlayFabMatchmaking), nameof(PlayFabMatchmaking.OnPlayFabLoginFinished))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(LoginType loginType)
            {
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
