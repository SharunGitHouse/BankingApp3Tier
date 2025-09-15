namespace BankingApp3Tier.Models
{
    public class SecondClass
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Description { get; set; }

        public SecondClass(int id,string name,string description) {
        
            Id = id;
            string Name = name;

            Description = description;  
        }    
    }
}
