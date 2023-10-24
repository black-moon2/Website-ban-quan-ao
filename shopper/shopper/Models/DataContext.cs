using Microsoft.EntityFrameworkCore;
using shopper.Models;

namespace shopper.Models
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
		public DbSet<Menu> Menus { get; set; }
	}
}