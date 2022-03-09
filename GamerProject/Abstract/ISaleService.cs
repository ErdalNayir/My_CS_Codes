using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    interface ISaleService
    {
        void SellGame(Game game,Gamer gamer);

        void SellDiscountedGame(Game game, Discount discount,Gamer gamer);
        
    }
}
