namespace UnitOfWorkPattern.Api.UnitOfWork
{
    using System;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Entities;
    using UnitOfWorkPattern.Api.Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            InitRepositories();
        }
        
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool _disposed = false;

        public IGenericRepository<Order> OrderRepository { get; private set; }

        public IGenericRepository<OrderDetails> OrderDetailsRepository { get; private set; }

        private void InitRepositories()
        {
            OrderRepository = new GenericRepository<Order>(_context);
            OrderDetailsRepository = new GenericRepository<OrderDetails>(_context);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
