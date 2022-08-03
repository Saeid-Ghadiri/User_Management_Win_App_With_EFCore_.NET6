namespace Data.Configurations
{
	internal class RoleConfiguration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Aggregates.Roles.Role>
	{
		public RoleConfiguration() : base()
		{
		}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Aggregates.Roles.Role> builder)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			//builder
			//	.HasIndex(propertyNames: "Name")
			//	.IsUnique(unique: true)
			//	;

			//builder
			//	.HasIndex(propertyNames: nameof(Domain.Aggregates.Roles.Role.Name))
			//	.IsUnique(unique: true)
			//	;

			//builder
			//	.HasIndex(indexExpression: current => current.Name)
			//	.IsUnique(unique: true)
			//	;

			//builder
			//	.HasIndex(indexExpression: current => new { current.Name })
			//	.IsUnique(unique: true)
			//	;

			builder
				.HasIndex(current => new { current.Name })
				.IsUnique(unique: true)
				;
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			//builder
			//	.HasMany(current => current.Users)
			//	.WithOne(other => other.Role)
			//	.IsRequired(required: true)
			//	.HasForeignKey(other => other.RoleId)
			//	.OnDelete(deleteBehavior:
			//		Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
			//	;

			builder
				.HasMany(current => current.Users)
				.WithOne(other => other.Role)
				.IsRequired(required: false)
				.HasForeignKey(other => other.RoleId)
				.OnDelete(deleteBehavior:
					Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
				;
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			//var role =
			//	new Domain.Aggregates.Roles.Role(name: "کاربر معمولی")
			//	{
			//		//Id,
			//		//Name,
			//		//Users
			//		//InsertDateTime,
			//		//UpdateDateTime,

			//		Ordering = 0,

			//		IsActive = true,
			//		IsSystemic = true,
			//		IsUndeletable = true,

			//		Description = null,
			//	};

			////role.SetId(id: Domain.Aggregates.Roles.Role.DefaultRoleId);

			//builder.HasData(data: role);
			// **************************************************
			// **************************************************
			// **************************************************
		}
	}
}
