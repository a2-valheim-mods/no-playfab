using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabManagerPatches
{
    public static class PlayFabManagerAwakePatch
    {
        [HarmonyPatch(typeof(PlayFabManager), nameof(PlayFabManager.Awake))]
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
