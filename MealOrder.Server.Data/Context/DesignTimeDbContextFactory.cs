using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MealOrder.Server.Data.Context
{
  public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MealOrderingDbContext>
  {
    public MealOrderingDbContext CreateDbContext(string[] args)
    {
      string connectionString = "User ID=postgres;password=1357913579;Host=localhost;Port=5432;Database=MealOrder";

      DbContextOptionsBuilder<MealOrderingDbContext> builder = new DbContextOptionsBuilder<MealOrderingDbContext>();

      builder.UseNpgsql(connectionString);

      return new MealOrderingDbContext(builder.Options);
    }
  }
}