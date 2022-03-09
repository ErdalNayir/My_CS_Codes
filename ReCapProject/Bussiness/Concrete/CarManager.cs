using Bussiness.Abstract;
using Data_Access.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {

            _carDal = carDal;
        }

        public void AddCar(Car car)
        {

            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Daily price 0'dan büyük olmalı");
            }
        }

        public void DeleteCar(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAllCars(Expression<Func<Car, bool>> filter=null)
        {
            return _carDal.GetAll(filter);
        }


        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(car=>car.BrandId==BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(car => car.ColorId == ColorId);
        }

        public void UpdateCar(Car car)
        {
            _carDal.Update(car);
        }

        
    }
}
