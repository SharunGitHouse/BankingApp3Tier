using BankingApp3Tier.BLL;      // Business Layer
using BankingApp3Tier.Models;   // Models
using Microsoft.AspNetCore.Mvc;

namespace BankingApp3Tier.Controllers
{
    public class BankingController : Controller
    {
        private readonly AccountService _service;

        public BankingController(AccountService service)
        {
            _service = service;
        }

        // Show all accounts
        public IActionResult Index()
        {
            var accounts = _service.GetAllAccounts();
            return View(accounts);
        }

        // Create account (GET)
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Create account (POST)
        [HttpPost]
        public IActionResult Create(Account account)
        {
            if (ModelState.IsValid)
            {
                _service.CreateAccount(account);
                return RedirectToAction("Index");
            }
            return View(account);
        }

        // Deposit
        [HttpPost]
        public IActionResult Deposit(int id, decimal amount)
        {
            _service.Deposit(id, amount);
            return RedirectToAction("Index");
        }

        // Withdraw
        [HttpPost]
        public IActionResult Withdraw(int id, decimal amount)
        {
            _service.Withdraw(id, amount);
            return RedirectToAction("Index");
        }
    }
}
