using CloudPartTwoPoe.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudPartTwoPoe.Services
{
	public class ProjectDbContext : DbContext
	{
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

		}

		public DbSet<Purchase> Purchase { get; set; } 

	}
}
