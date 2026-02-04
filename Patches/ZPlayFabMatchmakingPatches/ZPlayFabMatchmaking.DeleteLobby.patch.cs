#pragma warning disable IDE0060

using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.ZPlayFabMatchmakingPatches
{
    public static class ZPlayFabMatchmakingDeleteLobbyPatch
    {
        [HarmonyPatch(typeof(ZPlayFabMatchmaking), nameof(ZPlayFabMatchmaking.DeleteLobby))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(string lobbyId)
            {
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}

#pragma warning restore IDE0060