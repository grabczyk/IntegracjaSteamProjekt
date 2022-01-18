using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracjaSteamProjekt
{
    class Prices
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
