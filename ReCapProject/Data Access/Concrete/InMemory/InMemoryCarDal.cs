using Data_Access.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.InMemoryS
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _allCars = new List<Car> {
            new Car {Id=1,BrandId=2,ColorId=4,DailyPrice=350,ModelYear=2019,Description="Güzel Araba"},
            new Car {Id=2,BrandId=4,ColorId=4,DailyPrice=250,ModelYear=2017,Description="Daha Az Güzel Araba"},
            new Car {Id=3,BrandId=4,ColorId=1,DailyPrice=500,ModelYear=2020,Description="Daha Çok Güzel Araba"},
            new Car {Id=4,BrandId=7,ColorId=0,DailyPrice=1000,ModelYear=2021,Description="Süper Güzel Araba"},
            new Car {Id=5,BrandId=9,ColorId=6,DailyPrice=200,ModelYear=2015,Description="Güzel Araba Dermişim"}};

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void AddNewCar(Car car)
        {
            _allCars.Add(car);
            Console.WriteLine("Araba Eklendi");
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(Car car)
        {
            var toDeletedCar = _allCars.SingleOrDefault(p => p.Id == car.Id);

            _allCars.Remove(toDeletedCar);

            Console.WriteLine("Araba Silindi");
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCar()
        {
            Console.WriteLine("Araba Listesi Getiriliyor");
            return _allCars;
        }

        public List<Car> GetCarsByBrand(int BrandId)
        {
            var toReturnedCars = _allCars.Where(car => car.BrandId == BrandId).ToList();
            Console.WriteLine("Seçilen kritere sahip arabalar getiriliyor");

            return toReturnedCars;
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Car car)
        {
            var toUpdatedCar = _allCars.SingleOrDefault(p => p.Id == car.Id);

            toUpdatedCar.BrandId = car.BrandId;
            toUpdatedCar.ColorId = car.ColorId;
            toUpdatedCar.ModelYear = car.ModelYear;
            toUpdatedCar.DailyPrice = car.DailyPrice;
            toUpdatedCar.Description = car.Description;

            Console.WriteLine("Araba Güncellendi");
        }

       
    }
}
