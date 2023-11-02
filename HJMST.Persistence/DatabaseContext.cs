using HJMST.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HJMST.Persistence
{
	public class DatabaseContext :DbContext
	{
         public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options: options)
		{
			// TODO
			Database.EnsureCreated();
		}

		public DbSet<Googooli> Googoolis { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
