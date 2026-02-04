using HarmonyLib;
using System.Collections.Generic;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabMatchmakingPatches
{
    public static class PlayFabMatchmakingFilteredPublicServerListPatch
    {
        private static readonly IReadOnlyList<ServerData> _empty = new List<ServerData>().AsReadOnly();

        [HarmonyPatch(typeof(PlayFabMatchmaking), nameof(PlayFabMatchmaking.FilteredPublicServerList), MethodType.Getter)]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ref IReadOnlyList<ServerData> __result)
            {
                __result = _empty;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
