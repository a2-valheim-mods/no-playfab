using HarmonyLib;
using UnityEngine;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.PlayFabManagerPatches
{
    public static class PlayFabManagerHandleLogPatch
    {
        [HarmonyPatch(typeof(PlayFabManager), nameof(PlayFabManager.HandleLog))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix(string logString, string stackTrace, LogType type)
            {
                switch (type)
                {
                    case LogType.Error:
                        Jotunn.Logger.LogError($"{logString}");
                        break;
                    case LogType.Exception:
                        Jotunn.Logger.LogError($"{logString}\n{stackTrace}");
                        break;
                    case LogType.Warning:
                        Jotunn.Logger.LogError($"{logString}");
                        break;
                    case LogType.Log:
                        Jotunn.Logger.LogInfo($"{logString}");
                        break;
                    case LogType.Assert:
                        Jotunn.Logger.LogDebug($"{logString}");
                        break;
                }
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
