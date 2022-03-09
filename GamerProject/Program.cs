using GamerProject.Concrete;
using GamerProject.Entities;
using System;
using System.Collections.Generic;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();

            gamer1.Name = "Erdal";
            gamer1.Surname = "Nayir";
            gamer1.Password = "12345";
            gamer1.TcNum = "12345678901";
            gamer1.Balance = 5000;
            gamer1.Gender = "Male";
            gamer1.BirthYear = "2001";
            gamer1.UserName = "Pirasa01";

            Discount discount1 = new Discount();
            discount1.Name = "Muhteşem Cuma İndirimi";
            discount1.Name = "30";

            Game game1 = new Game();
            game1.Name = "Assasin's Greed";
            game1.Price = 25;
            game1.CreatedBy = "EA";

            List<Game> gameList = new List<Game>();
            List<Discount> discounts = new List<Discount>();

            gameList.Add(game1);
            discounts.Add(discount1);

            ValidatorService validator = new ValidatorService();
            GamerService gamerService = new GamerService();
            GameService gameService = new GameService();
            DiscountService discountService = new DiscountService();

            if (validator.ValidateGamer(gamer1))
            {
                Console.WriteLine("Kullanıcı Doğrulandı hoş geldin Pirasa01 !");
                gameService.SellDiscountedGame(gameList[0], discounts[0], gamer1);
                Console.WriteLine("Yeni bakiyeniz: " + gamer1.Balance);

            }
            else
            {
                Console.WriteLine("Böyle bir kullanıcı Bulunamadı.");
            }

            

        }
    }
}
