using Data_Access.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.Entity_Framework
{
    public class EfColorsDal : IColorsDal
    {
        private EfOperations _operations;

        public EfColorsDal(EfOperations operations)
        {
            _operations = operations;
        }

        public void Add(Colors entity)
        {
            _operations.Add(entity);
        }

        public void Delete(Colors entity)
        {
            _operations.Delete(entity);
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Colors>().SingleOrDefault(filter);
            }
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? context.Set<Colors>().ToList() : context.Set<Colors>().Where(filter).ToList();
            }
        }

        public void Update(Colors entity)
        {
            _operations.Update(entity);
        }
    }
}
