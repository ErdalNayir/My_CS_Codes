using Data_Access.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.Entity_Framework
{
    public class EfOperations
    {
        public void Add(IEntity entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            Console.WriteLine("Entity Eklendi");
        }

        public void Delete(IEntity entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


        public void Update(IEntity entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }


    }
}
