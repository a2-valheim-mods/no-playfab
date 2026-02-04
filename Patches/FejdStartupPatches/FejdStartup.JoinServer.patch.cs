using HarmonyLib;
using A2.NoPlayFab.Patches.PlayFabManagerPatches;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.FejdStartupPatches
{
    public static class FejdStartupJoinServerTabPatch
    {
        [HarmonyPatch(typeof(FejdStartup), nameof(FejdStartup.JoinServer))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(FejdStartup __instance)
            {
                if(__instance.m_joinServer.m_type == ServerJoinDataType.PlayFabUser)
                {
                    UnifiedPopup.Push(new WarningPopup("PlayFab disabled", "Cannot join server because PlayFab is disabled.", () => UnifiedPopup.Pop()));
                    return HARMONY_PREFIX_RESULT_BREAK;
                }
                PlayFabManagerIsLoggedInPatch.NextValue = true;
                return HARMONY_PREFIX_RESULT_CONTINUE;
            }
        }
    }
}
