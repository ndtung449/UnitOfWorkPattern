namespace UnitOfWorkPattern.Api.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IBaseService<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        Task<TDto> CreateAsync(TDto dto);

        Task<TDto> UpdateAsync(TDto dto);

        Task DeleteAsync(object keyValues);

        Task<TDto> FindByIdAsync(object keyValues);

        Task<PaginatedList<TEntity, TDto>> FindAsync(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int page = 1);
    }
}
