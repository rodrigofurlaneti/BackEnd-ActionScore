using FSI.ActionScore.Domain.Interfaces;
using FSI.ActionScore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSI.ActionScore.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ActionScoreDbContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(ActionScoreDbContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<int> InsertAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity);
            await Context.SaveChangesAsync();

            var idProperty = typeof(TEntity).GetProperty("Id");
            var idValue = (int)(idProperty?.GetValue(entity) ?? 0);
            return idValue;
        }

        public virtual async Task<bool> UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            var rows = await Context.SaveChangesAsync();
            return rows > 0;
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity is null)
            {
                return false;
            }

            DbSet.Remove(entity);
            var rows = await Context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
