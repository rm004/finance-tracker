using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models;

public class TransactionCategory
{
    public Guid Id { get; set; }
    
    [Required, MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public Guid UserId { get; set; }
    public User? User { get; set; }
    
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}