using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabManagerPatches
{
    public static class PlayFabManagerIsLoggedInPatch
    {
        public static bool NextValue = false;

        [HarmonyPatch(typeof(PlayFabManager), nameof(PlayFabManager.IsLoggedIn), MethodType.Getter)]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(ref bool __result)
            {
                __result = NextValue;
                NextValue = false;
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
