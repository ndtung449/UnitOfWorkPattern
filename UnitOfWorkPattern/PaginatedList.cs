namespace UnitOfWorkPattern.Api
{
    using global::AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PaginatedList<TEntity, TDto> : List<TDto>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<TDto> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;

        public static async Task<PaginatedList<TEntity, TDto>> CreateAsync(IQueryable<TEntity> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var entities = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            var dtos = Mapper.Map<List<TDto>>(entities);
            return new PaginatedList<TEntity, TDto>(dtos, count, pageIndex, pageSize);
        }
    }
}
