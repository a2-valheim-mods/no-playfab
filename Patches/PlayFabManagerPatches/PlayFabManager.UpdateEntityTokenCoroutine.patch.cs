using HarmonyLib;
using System.Collections;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabManagerPatches
{
    public static class PlayFabManagerUpdateEntityTokenCoroutinePatch
    {
        [HarmonyPatch(typeof(PlayFabManager), nameof(PlayFabManager.UpdateEntityTokenCoroutine))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ref IEnumerator __result)
            {
                __result = EmptyCoroutine();
                return HARMONY_PREFIX_RESULT_BREAK;
            }

            private static IEnumerator EmptyCoroutine()
            {
                yield break;
            }
        }
    }
}
