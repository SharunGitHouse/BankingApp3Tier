using System.ComponentModel.DataAnnotations;

namespace BankingApp3Tier.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        public string AccountHolder { get; set; }

        [Required]
        public decimal Balance { get; set; }
    }
}
