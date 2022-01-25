﻿namespace IntegracjaSteamProjekt
{
    /// <summary>
    /// Klasa dla danych dotyczących cen gier
    /// </summary>
    class GamesPrices
    {
        public class Rootobject
        {
            public string currency { get; set; }
            public int initial { get; set; }
            public int final { get; set; }
            public int discount_percent { get; set; }
            public string initial_formatted { get; set; }
            public string final_formatted { get; set; }
        }

    }
}
