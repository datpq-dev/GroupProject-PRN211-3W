using BookLibrary_Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public class GenericRepository<T> where T : class
    {
        private readonly LibrarySystemManagementContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository()
        {
            _dbContext = new LibrarySystemManagementContext();
            _dbSet = _dbContext.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Add(T item)
        {
            _dbSet.Add(item);
            _dbContext.SaveChanges();
        }
        public void Delete(T item)
        {
            _dbSet.Remove(item);
            _dbContext.SaveChanges();
        }
        public void Update(T item)
        {
            var tracker = _dbContext.Attach(item);
            tracker.State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
