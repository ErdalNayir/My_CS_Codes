using Data_Access.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.Entity_Framework
{
    public class EfBrandsDal:IBrandsDal
    {
        private EfOperations _operations;

        public EfBrandsDal(EfOperations operations)
        {
            this._operations = operations;
        }

        public void Add(Brands entity)
        {
            _operations.Add(entity);
        }

        public void Delete(Brands entity)
        {
            _operations.Delete(entity);
        }

        public Brands Get(Expression<Func<Brands, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Brands>().SingleOrDefault(filter);
            }
        }

        public List<Brands> GetAll(Expression<Func<Brands, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? context.Set<Brands>().ToList() : context.Set<Brands>().Where(filter).ToList();
            }
        }

        public void Update(Brands entity)
        {
            _operations.Update(entity);
        }
    }
}
