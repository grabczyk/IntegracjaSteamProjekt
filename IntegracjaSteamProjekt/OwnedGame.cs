namespace IntegracjaSteamProjekt
{
    /// <summary>
    /// Klasa dla danych dotyczących gier, które posiada gracz
    /// </summary>
    public class OwnedGame
    {
        public uint GameId { get; set; }
        public string Name { get; set; }
        public int PlayTime { get; set; }
        public string Description { get; set; }
    }
}
