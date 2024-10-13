using Microsoft.EntityFrameworkCore;

namespace SpendMaker.Models
{
    public class SpendMakerDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public SpendMakerDbContext(DbContextOptions<SpendMakerDbContext> options) : base(options)
        {
            
        }
    }
}
