namespace UnitOfWorkPattern.Api
{
    using Microsoft.EntityFrameworkCore;
    using UnitOfWorkPattern.Api.Entities;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
