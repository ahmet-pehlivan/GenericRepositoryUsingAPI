using Microsoft.EntityFrameworkCore;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infrastructure
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}
