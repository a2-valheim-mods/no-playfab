using HarmonyLib;
using System.Linq;
using UnityEngine;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.FejdStartupPatches
{
    public static class MultiBackendMatchmakingConstructorPatch
    {
        [HarmonyPatch(typeof(MultiBackendMatchmaking), MethodType.Constructor)]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static void Postfix(MultiBackendMatchmaking __instance)
            {
                var playFabMatchmaking = __instance.m_backends.FirstOrDefault(b => b is PlayFabMatchmaking);
                if (playFabMatchmaking is not null)
                {
                    __instance.m_backends.Remove(playFabMatchmaking);
                    playFabMatchmaking.Dispose();
                }
            }
        }
    }
}