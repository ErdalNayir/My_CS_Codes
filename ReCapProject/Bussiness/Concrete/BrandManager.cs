using Bussiness.Abstract;
using Data_Access.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandsDal _brandDal;

        public BrandManager(IBrandsDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void AddBrand(Brands brand)
        {
            _brandDal.Add(brand);
        }

        public void DeleteBrand(Brands brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brands> GetAllBrands()
        {
            return GetAllBrands();
        }

        public void UpdateBrand(Brands brand)
        {
            _brandDal.Update(brand);
        }
    }
}
