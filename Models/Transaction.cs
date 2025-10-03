using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models;

public class Transaction
{
    public Guid Id { get; set; }
    
    [Required, MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [Required, MaxLength(50)]
    public string Vendor { get; set; } = string.Empty;
    
    public decimal Amount { get; set; }
    
    public DateTime Date { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public Guid TransactionCategoryId { get; set; }
    public TransactionCategory? TransactionCategory { get; set; }
    
    public Guid BankAccountId { get; set; }
    public BankAccount? BankAccount { get; set; }
}