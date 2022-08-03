using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
	{
		// در EF Core .NET
		// //6
		//public DatabaseContext() : base()
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public DatabaseContext() : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		{
			// **************************************************
			Database.EnsureCreated();
			// **************************************************
		}

		public Microsoft.EntityFrameworkCore.DbSet<Domain.Aggregates.Roles.Role> Roles { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Domain.Aggregates.Users.User> Users { get; set; }

		public Microsoft.EntityFrameworkCore.DbSet<Domain.Aggregates.Users.UserLogin> UserLogins { get; set; }

		protected override void OnConfiguring
			(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString =
				"Server=.;Database=Atria;MultipleActiveResultSets=true;User ID=sa;Password=123;";

			// UseSqlServer() -> using Microsoft.EntityFrameworkCore;
			optionsBuilder.UseSqlServer
				(connectionString: connectionString);
		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);
		//}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Solution (1)
			//modelBuilder
			//	.Entity<Domain.Role>()
			//	.HasIndex(current => new { current.Name })
			//	.IsUnique(unique: true)
			//	;
			// /Solution (1)

			// Solution (2)
			//modelBuilder.ApplyConfiguration
			//	(configuration: new Configurations.RoleConfiguration());
			// /Solution (2)

			// Solution (3)
			//new Configurations.RoleConfiguration()
			//	.Configure(builder: modelBuilder.Entity<Domain.Role>());
			// /Solution (3)

			// Solution (4)
			//modelBuilder.ApplyConfigurationsFromAssembly
			//	(assembly: System.Reflection.Assembly.GetExecutingAssembly());
			// /Solution (4)

			// Solution (5)
			modelBuilder.ApplyConfigurationsFromAssembly
				(assembly: typeof(Configurations.RoleConfiguration).Assembly);
			// /Solution (5)
		}
	}
}
