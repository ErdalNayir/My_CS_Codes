using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCars(Expression<Func<Car,bool>> filter=null);
        void UpdateCar(Car car);
        void DeleteCar(Car car);
        List<Car> GetCarsByBrandId(int BrandId);
        List<Car> GetCarsByColorId(int ColorId);
        void AddCar(Car car);



    }
}
