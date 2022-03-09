using Bussiness.Concrete;
using Data_Access.Abstract;
using Data_Access.Concrete.Entity_Framework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
         
            CarManager carManager = new CarManager(new EfCarDal(new EfOperations()));
            ColorManager colorManager = new ColorManager(new EfColorsDal(new EfOperations()));
            BrandManager brandManager = new BrandManager(new EfBrandsDal(new EfOperations()));


            var filteredCars=carManager.GetAllCars();

            foreach(var car in filteredCars)
            {
                car.Display();
            }

            Console.WriteLine("\n\n");

            var carsById = carManager.GetCarsByBrandId(1);

            foreach (var car in carsById)
            {
                car.Display();
            }


        }
    }
}
