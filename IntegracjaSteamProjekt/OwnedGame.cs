using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracjaSteamProjekt
{
    public class OwnedGame
    {
        public uint GameId { get; set; }
        public string Name { get; set; }
        public int PlayTime { get; set; }
        public string Description { get; set; }
    }
}
