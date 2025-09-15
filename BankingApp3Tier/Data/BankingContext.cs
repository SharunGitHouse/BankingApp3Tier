using Microsoft.EntityFrameworkCore;
using BankingApp3Tier.Models;

namespace BankingApp3Tier.Data
{
    public class BankingContext : DbContext
    {
        public BankingContext(DbContextOptions<BankingContext> options) : base(options) { }

        public DbSet<Account> Accounts3teir { get; set; }
    }
}
