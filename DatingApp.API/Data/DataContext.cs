using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
	public class DataContext : DbContext
	{
		// dotnet ef migrations add "InitialCreate"
		// dotnet ef database update
		public DataContext(DbContextOptions<DataContext> options) : base(options)	{}

		public DbSet<Value> Values { get; set; }
	}
}