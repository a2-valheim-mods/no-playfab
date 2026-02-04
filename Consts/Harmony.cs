namespace A2.NoPlayFab.Consts
{
    internal static class Harmony
    {
        /// <summary>
        /// Indicates that Harmony should continue execution and invoke
        /// the original method after the <c>Prefix</c> patch completes.
        /// </summary>
        /// <remarks>
        /// When a <c>Prefix</c> patch returns <c>true</c>, Harmony allows the
        /// original method to run normally.
        /// <para/>
        /// Use this value when the prefix only performs validation,
        /// logging, or state modification and does not intend to replace
        /// the original method's behavior.
        /// </remarks>
        /// <example>
        /// <code>
        /// [HarmonyPrefix]
        /// static bool Prefix()
        /// {
        ///     // Allow original method to execute
        ///     return Constants.HARMONY_PREFIX_RESULT_CONTINUE;
        /// }
        /// </code>
        /// </example>
        public const bool HARMONY_PREFIX_RESULT_CONTINUE = true;
        /// <summary>
        /// Indicates that Harmony should skip execution of the original method
        /// after the <c>Prefix</c> patch completes.
        /// </summary>
        /// <remarks>
        /// When a <c>Prefix</c> patch returns <c>false</c>, Harmony prevents the
        /// original method from being executed.
        /// <para/>
        /// This is commonly used when the prefix fully replaces the method's
        /// behavior, sets the return value via <c>__result</c>, or intentionally
        /// blocks the original logic.
        /// </remarks>
        /// <example>
        /// <code>
        /// [HarmonyPrefix]
        /// static bool Prefix(ref int __result)
        /// {
        ///     __result = 42;
        ///     // Prevent original method from executing
        ///     return Constants.HARMONY_PREFIX_RESULT_BREAK;
        /// }
        /// </code>
        /// </example>
        public const bool HARMONY_PREFIX_RESULT_BREAK = false;
        /// <summary>
        /// The Harmony patch priority value to run the patch as early as possible.
        /// </summary>
        /// <remarks>
        /// Assigning this priority ensures the patch executes before most other patches.
        /// </remarks>
        public const int HARMONY_PATCH_PRIORITY_FIRST = int.MinValue;
    }
}
