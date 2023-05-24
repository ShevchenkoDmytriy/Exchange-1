using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;


public class ApplicationContext : DbContext
{
    public DbSet<Users> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source = HOME-PC; Initial Catalog = Exchange; Trusted_Connection=True; TrustServerCertificate=True");
    }
}