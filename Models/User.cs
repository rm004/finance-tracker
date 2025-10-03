using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models;

public class User
{
    public Guid Id { get; set; }
    
    [Required, MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [Required, MaxLength(25)]
    public string Username { get; set; } = string.Empty;
    
    [Required, MaxLength(25)]
    public string Email { get; set; } = string.Empty;
    
    [Required, MaxLength(25)]
    public string PasswordHash { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public Goal? Goal { get; set; }
    public ICollection<TransactionCategory> TransactionCategories { get; set; } = new List<TransactionCategory>();
    public ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}