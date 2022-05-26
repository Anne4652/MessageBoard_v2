﻿using MessageBoard.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
       where TEntity : class
    {
        public readonly BoardDbContext _context;

        public Repository(BoardDbContext context)
        {
            _context = context;
        }

        public virtual async Task CreateAsync(TEntity item)
        {
            await _context.Set<TEntity>().AddAsync(item);
        }

        public virtual async Task<TEntity> GetItemAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual void Delete(TEntity item)
        {
            _context.Set<TEntity>().Remove(item);
        }

        public virtual async Task DeleteByIdAsync(int id)
        {
            Delete(await GetItemAsync(id));
        }

        public virtual async Task<IEnumerable<TEntity>> ListItemsAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public virtual void Update(TEntity model)
        {
            _context.Set<TEntity>().Attach(model);
            _context.Entry(model).State = EntityState.Modified;
        }
    }
}
