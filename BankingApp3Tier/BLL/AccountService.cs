using BankingApp3Tier.DAL;
using BankingApp3Tier.Models;

namespace BankingApp3Tier.BLL
{
    public class AccountService
    {
        private readonly AccountRepository _repository;

        public AccountService(AccountRepository repository)
        {
            _repository = repository;
        }

        public List<Account> GetAllAccounts() => _repository.GetAll();

        public void CreateAccount(Account account) => _repository.Add(account);

        public void Deposit(int id, decimal amount)
        {
            var account = _repository.GetById(id);
            if (account != null)
            {
                account.Balance += amount;
                _repository.Update(account);
            }
        }

        public void Withdraw(int id, decimal amount)
        {
            var account = _repository.GetById(id);
            if (account != null && account.Balance >= amount)
            {
                account.Balance -= amount;
                _repository.Update(account);
            }
        }
    }
}
