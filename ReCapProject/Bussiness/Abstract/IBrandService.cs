using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {
        List<Brands> GetAllBrands();
        void UpdateBrand(Brands brand);
        void DeleteBrand(Brands brand);
        void AddBrand(Brands brand);
    }
}
