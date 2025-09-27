using System.ComponentModel.DataAnnotations;

namespace BankingApp3Tier.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        public required string AccountHolder { get; set; }

        [Required]
        public decimal Balance { get; set; }

    }
}
