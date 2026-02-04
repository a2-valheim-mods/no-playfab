#pragma warning disable IDE0060

using HarmonyLib;
using PlayFab;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabAuthWithGameCenterPatches
{
    public static class PlayFabAuthWithGameCenterOnLoginFailurePatch
    {
        [HarmonyPatch(typeof(PlayFabAuthWithGameCenter), nameof(PlayFabAuthWithGameCenter.OnLoginFailure))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(PlayFabError error)
            {
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}

#pragma warning restore IDE0060