using HarmonyLib;
using UnityEngine;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.FejdStartupPatches
{
    public static class FejdStartupOnWorldStartPatch
    {
        [HarmonyPatch(typeof(FejdStartup), nameof(FejdStartup.OnWorldStart))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(FejdStartup __instance)
            {
                if (PlayerPrefs.GetInt("crossplay", 0) != 0)
                {
                    PlayerPrefs.SetInt("crossplay", 0);
                }
                __instance.m_crossplayServerToggle.isOn = false;
                return HARMONY_PREFIX_RESULT_CONTINUE;
            }
        }
    }
}