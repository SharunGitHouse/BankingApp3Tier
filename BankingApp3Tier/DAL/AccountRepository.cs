using BankingApp3Tier.Data;
using BankingApp3Tier.Models;

namespace BankingApp3Tier.DAL
{
    public class AccountRepository
    {
        private readonly BankingContext _context;

        public AccountRepository(BankingContext context)
        {
            _context = context;
        }

        public List<Account> GetAll() => _context.Accounts3teir.ToList();

        public Account GetById(int id) => _context.Accounts3teir.Find(id);

        public void Add(Account account)
        {
            _context.Accounts3teir.Add(account);
            _context.SaveChanges();
        }

        public void Update(Account account)
        {
            _context.Accounts3teir.Update(account);
            _context.SaveChanges();
        }
    }
}
