﻿using Data_Access.Abstract;
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
    public class EfCarDal : ICarDal
    {
        private EfOperations _operations;

        public EfCarDal(EfOperations operations)
        {
            _operations = operations;
        }

        public void Add(Car entity)
        {
            _operations.Add(entity);
        }

        public void Delete(Car entity)
        {
            _operations.Delete(entity);
            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            _operations.Update(entity);
            
        }
    }
}
