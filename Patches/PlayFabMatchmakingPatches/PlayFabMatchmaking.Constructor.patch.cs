using HarmonyLib;
using System;
using System.Reflection;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabMatchmakingPatches
{
    public static class PlayFabMatchmakingConstructorPatch
    {
        [HarmonyPatch]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static MethodBase TargetMethod()
            {
                return typeof(PlayFabMatchmaking)
                    .GetConstructor(
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                        null,
                        Type.EmptyTypes,
                        null
                    );
            }

            public static void Postfix(PlayFabMatchmaking __instance)
            {
                __instance.Dispose();
            }
        }
    }
}
