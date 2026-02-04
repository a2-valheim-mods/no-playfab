#pragma warning disable IDE0060

using HarmonyLib;
using PlayFab.CloudScriptModels;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabManagerPatches
{
    public static class PlayFabManagerOnCloudDeletePlayerResultPatch
    {
        [HarmonyPatch(typeof(PlayFabManager), nameof(PlayFabManager.OnCloudDeletePlayerResult))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ExecuteCloudScriptResult obj)
            {
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}

#pragma warning restore IDE0060