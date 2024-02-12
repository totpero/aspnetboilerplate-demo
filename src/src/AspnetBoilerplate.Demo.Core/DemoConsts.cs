using AspnetBoilerplate.Demo.Debugging;

namespace AspnetBoilerplate.Demo
{
    public class DemoConsts
    {
        public const string LocalizationSourceName = "Demo";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b1cd2960bff940c88869dd60e67c376a";
    }
}
