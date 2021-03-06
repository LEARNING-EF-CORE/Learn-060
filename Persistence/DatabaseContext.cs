using Microsoft.EntityFrameworkCore;

namespace Persistence
{
	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
	{
		public DatabaseContext() : base()
		{
			//Database.EnsureCreated();
		}

		public Microsoft.EntityFrameworkCore.DbSet<Domain.Aggregates.Users.User> Users { get; set; }

		protected override void OnConfiguring
			(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);

			string connectionString =
				"Password=1234512345;Persist Security Info=True;User ID=SA;Initial Catalog=LEARNING_EF_CORE_6;Data Source=.";

			optionsBuilder
				// using Microsoft.EntityFrameworkCore;
				.UseLazyLoadingProxies()
				// using Microsoft.EntityFrameworkCore;
				.UseSqlServer(connectionString: connectionString)
				;
			;
		}

		protected override void OnModelCreating
			(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly
				(assembly: typeof(Persistence.Aggregates.Users.UserConfiguration).Assembly);
		}
	}
}
