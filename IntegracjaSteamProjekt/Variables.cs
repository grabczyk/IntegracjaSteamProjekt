using System.Configuration;

namespace IntegracjaSteamProjekt
{
    class Variables
    {
        public static string ApiKey
        {
            get
            {
                return ConfigurationManager.AppSettings["steamApiKey"];
            }
        }

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["connectionString"];
            }
        }
    }
}
