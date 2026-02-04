using HarmonyLib;
using UnityEngine;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabManagerPatches
{
    public static class PlayFabManagerInitializePatch
    {
        [HarmonyPatch(typeof(PlayFabManager), nameof(PlayFabManager.Initialize))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix()
            {
                if (PlayFabManager.instance is null)
                {
                    new GameObject(nameof(PlayFabManager)).AddComponent<PlayFabManager>();
                }
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
