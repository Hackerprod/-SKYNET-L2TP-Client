using System;

namespace SKYNET.Helpers
{
    public class Settings
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string PreSharedKey { get; set; }
        public static string Server { get; set; }
        public static bool AutoConnect { get; set; }
        


        private static RegistrySettings Registry;

        static Settings()
        {
            Registry = new RegistrySettings(@"SOFTWARE\SKYNET\ISP CUBA ONLINE\");
        }

        public static void Load()
        {
            Username = Registry.Get<string>("Username", "");
            Password = Registry.Get<string>("Password", "");
            PreSharedKey = Registry.Get<string>("PreSharedKey", "");
            Server = Registry.Get<string>("Server", "");
            AutoConnect = Registry.Get<bool>("AutoConnect", false);
        }

        public static void Save()
        {
            Registry.Set("Username", Username);
            Registry.Set("Password", Password);
            Registry.Set("PreSharedKey", PreSharedKey);
            Registry.Set("Server", Server);
            Registry.Set("AutoConnect", AutoConnect);
            
        }
    }
}

