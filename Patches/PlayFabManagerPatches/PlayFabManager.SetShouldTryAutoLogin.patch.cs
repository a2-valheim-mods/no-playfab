using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabManagerPatches
{
    public static class PlayFabManagerSetShouldTryAutoLoginPatch
    {
        [HarmonyPatch(typeof(PlayFabManager), nameof(PlayFabManager.SetShouldTryAutoLogin))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(PlayFabManager __instance, bool value)
            {
                __instance.m_shouldTryAutoLogin = false;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
