using EcartAssiggmnet.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Data
{
    public class EcartRepository<T>: IRepository<T> where T : BaseEntity
    {
        private readonly EcartContext context;
        private DbSet<T> entity;
        public EcartRepository(EcartContext context)
        {
            this.context = context;
            entity = context.Set<T>();
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.entity;
            }
        }


        public void Delete(T entity)
        {
            
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.entity.Remove(entity);
                this.context.SaveChanges();
           
            
        }


        T IRepository<T>.GetById(object id)
        {
            return this.entity.Find(id);
        }

        public void Insert(T entity)
        {
           
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.entity.Add(entity);
                this.context.SaveChanges();
           
           
        }

        public void Update(T entity)
        {
            
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.context.SaveChanges();
            
        }
    }
}
