using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabAuthWithGameCenterPatches
{
    public static class PlayFabAuthWithGameCenterLoginPatch
    {
        [HarmonyPatch(typeof(PlayFabAuthWithGameCenter), nameof(PlayFabAuthWithGameCenter.Login))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix()
            {
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
