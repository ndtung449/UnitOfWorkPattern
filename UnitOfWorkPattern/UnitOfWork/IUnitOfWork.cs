namespace UnitOfWorkPattern.Api.UnitOfWork
{
    using System;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Entities;
    using UnitOfWorkPattern.Api.Repositories;

    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Order> OrderRepository { get; }
        IGenericRepository<OrderDetails> OrderDetailsRepository { get; }
        Task SaveAsync();
    }
}
