using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    class GameService : ISaleService
    {
        public void SellDiscountedGame(Game game, Discount discount, Gamer gamer)
        {
            Console.WriteLine(game.Name + " adlı oyunu satın aldınız İndirimli Fiyat: " + (game.Price-((game.Price*discount.Percantage)/100)));
            gamer.Balance -= game.Price;
        }

        public void SellGame(Game game, Gamer gamer)
        {
            Console.WriteLine(game.Name + " adlı oyunu satın aldınız Fiyat: " + game.Price);
            gamer.Balance -= game.Price;

            
        }


    }
}

