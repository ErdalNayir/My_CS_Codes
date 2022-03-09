using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    class ValidatorService
    {
        public bool ValidateGamer(Entities.Gamer gamer)
        {
            if(gamer.Name=="Erdal" && gamer.Surname == "Nayir")
            {
                if (gamer.TcNum == "12345678901")
                {
                    return true;
                }
                return false;
            }
            return false;
        } 
    }
}
