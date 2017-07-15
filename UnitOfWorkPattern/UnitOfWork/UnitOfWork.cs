namespace UnitOfWorkPattern.Api.UnitOfWork
{
    using System;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Entities;
    using UnitOfWorkPattern.Api.Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext _context;
        private IGenericRepository<CompetencyRating> _competencyRatingRepository;
        private IGenericRepository<Interview> _interviewRepository;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public IGenericRepository<CompetencyRating> CompetencyRatingRepository => _competencyRatingRepository ??
            (_competencyRatingRepository = new GenericRepository<CompetencyRating>(_context));

        public IGenericRepository<Interview> InterviewRepository => _interviewRepository ??
            (_interviewRepository = new GenericRepository<Interview>(_context));

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool _disposed = false;

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
