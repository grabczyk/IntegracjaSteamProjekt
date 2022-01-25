using System.Configuration;

namespace IntegracjaSteamProjekt
{
    /// <summary>
    /// Pomocniczna klasa z danymi konfiguracyjnymi
    /// </summary>
    class Variables
    {
        /// <summary>
        /// Klucz do Steam API
        /// </summary>
        public static string ApiKey
        {
            get
            {
                return ConfigurationManager.AppSettings["steamApiKey"];
            }
        }

        /// <summary>
        /// Connection string do bazy danych
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["connectionString"];
            }
        }
    }
}
