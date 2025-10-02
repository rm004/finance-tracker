namespace FinanceTracker.Models;

public class Goal
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal MonthlySavings { get; set; }
    public decimal MonthlyIncome { get; set; }
    public decimal MonthlySpending { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}