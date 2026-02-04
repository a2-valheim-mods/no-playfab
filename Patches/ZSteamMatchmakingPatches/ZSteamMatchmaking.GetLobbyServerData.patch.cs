#pragma warning disable IDE0060

using HarmonyLib;
using Steamworks;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.ZPlayFabMatchmakingPatches
{
    public static class ZSteamMatchmakingGetLobbyServerDataPatch
    {
        [HarmonyPatch(typeof(ZSteamMatchmaking), nameof(ZSteamMatchmaking.GetLobbyServerData))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static void Postfix(ref ServerData __result, CSteamID lobbyID)
            {
                if(__result.m_joinData.m_type == ServerJoinDataType.PlayFabUser)
                {
                    __result = ServerData.None;
                }
            }
        }
    }
}

#pragma warning restore IDE0060