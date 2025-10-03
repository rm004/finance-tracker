using FinanceTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User <-> Goal (one User to one Goal)
        modelBuilder.Entity<User>()
            .HasOne(u => u.Goal)
            .WithOne(g => g.User)
            .HasForeignKey<Goal>(g => g.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        // User <-> TransactionCategory (one User to many TransactionCategories)
        modelBuilder.Entity<TransactionCategory>()
            .HasOne(tc => tc.User)
            .WithMany(u => u.TransactionCategories)
            .HasForeignKey(tc => tc.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        // User <-> BankAccount (one User to many BankAccounts)
        modelBuilder.Entity<BankAccount>()
            .HasOne(ba => ba.User)
            .WithMany(u => u.BankAccounts)
            .HasForeignKey(ba => ba.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        // TransactionCategory <-> Transaction (one TransactionCategory to many Transactions)
        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.TransactionCategory)
            .WithMany(tc => tc.Transactions)
            .HasForeignKey(t => t.TransactionCategoryId)
            .OnDelete(DeleteBehavior.Restrict);
        
        // BankAccount <-> Transaction (one BankAccount to many Transactions)
        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.BankAccount)
            .WithMany(ba => ba.Transactions)
            .HasForeignKey(t => t.BankAccountId)
            .OnDelete(DeleteBehavior.Restrict);
        
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionCategory> TransactionCategories { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }
    public DbSet<Goal> Goals { get; set; }
}