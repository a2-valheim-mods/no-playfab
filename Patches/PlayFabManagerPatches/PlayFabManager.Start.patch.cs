using HarmonyLib;
using UnityEngine;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabManagerPatches
{
    public static class PlayFabManagerStartPatch
    {
        [HarmonyPatch(typeof(PlayFabManager), nameof(PlayFabManager.Start))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(PlayFabManager __instance)
            {
                if (PlayFabManager.instance is not null && __instance is not null)
                {
                    Object.Destroy(__instance);
                }
                else
                {
                    if(__instance is not null) Object.DontDestroyOnLoad(__instance.gameObject);
                    PlayFabManager.instance = __instance;
                }
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
