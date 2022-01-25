using System.IO;
using System.Text;

namespace IntegracjaSteamProjekt
{
    /// <summary>
    /// Zmodyfikowana klasa StringWritera w celu użycia kodowania UTF8 przy eksportowaniu do XML
    /// </summary>
    class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
