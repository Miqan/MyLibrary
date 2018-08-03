using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly ApplicationDbContext context;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public void Delete(string id)
        {
            var entityToDelete = Get(id);
            entities.Remove(entityToDelete);
            context.SaveChanges();
        }

        public T Get(string id)
        {
            return entities.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Update(entity);
            context.SaveChanges();
        }
    }
}
