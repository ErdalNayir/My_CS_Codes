using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    class GamerService
    {
        public void updateUserName(Entities.Gamer gamer,string username)
        {
            gamer.UserName = username;
        }

        public void updatePassword(Entities.Gamer gamer, string password)
        {
            gamer.Password = password;
        }

        public void addBalance(Entities.Gamer gamer, int goingToBeAdded)
        {
            gamer.Balance += goingToBeAdded;
        }

    }
}
