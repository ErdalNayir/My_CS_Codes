using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Entities
{
    class Gamer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNum { get; set; }
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        List<Game> purchasedGames =new List<Game>();

    }
}
