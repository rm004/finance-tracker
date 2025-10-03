using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models;

public class Goal
{
    public Guid Id { get; set; }
    
    [Required, MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    public decimal MonthlySavings { get; set; }
    
    public decimal MonthlyIncome { get; set; }
    
    public decimal MonthlySpending { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public Guid UserId { get; set; }
    public User? User { get; set; }
}