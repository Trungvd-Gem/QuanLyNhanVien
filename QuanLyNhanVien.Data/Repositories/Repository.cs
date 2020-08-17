using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Core.Data;
using QuanLyNhanVien.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Core.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        protected readonly QuanLyNhanVienDbContext DbContext;

        public Repository(QuanLyNhanVienDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<T> GetAsync(Guid id) => await DbContext.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> GetAllAsync() => await DbContext.Set<T>().ToListAsync();

        public async Task<T> AddAsync(T entity)
        {
            DbContext.Set<T>().Add(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            await DbContext.SaveChangesAsync();
        }

    }
}
