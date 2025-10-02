namespace FinanceTracker.Models;

public class BankAccount
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public BankAccountType Type { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}

public enum BankAccountType
{
    Checking,
    Savings,
    Debt
}