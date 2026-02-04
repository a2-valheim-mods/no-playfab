using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.ZPlayFabLobbySearchPatches
{
    public static class ZPlayFabLobbySearcFindLobbyPatch
    {
        [HarmonyPatch(typeof(ZPlayFabLobbySearch), nameof(ZPlayFabLobbySearch.FindLobby))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ZPlayFabLobbySearch __instance)
            {
                if (__instance?.m_finishedAction is not null)
                {
                    __instance.IsDone = true;
                    __instance.m_finishedAction(ZPLayFabMatchmakingFailReason.None);
                }
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
