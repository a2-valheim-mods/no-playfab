#pragma warning disable IDE0060

using HarmonyLib;
using PlayFab.ClientModels;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabManagerPatches
{
    public static class PlayFabManagerOnLoginSuccessPatch
    {
        [HarmonyPatch(typeof(PlayFabManager), nameof(PlayFabManager.OnLoginSuccess))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(LoginResult result)
            {
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}

#pragma warning restore IDE0060