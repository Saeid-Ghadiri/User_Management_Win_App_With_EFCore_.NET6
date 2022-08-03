namespace Data.Configurations
{
	internal class UserLoginConfiguration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Aggregates.Users.UserLogin>
	{
		public UserLoginConfiguration() : base()
		{
		}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Aggregates.Users.UserLogin> builder)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			builder
				.Property(current => current.UserIP)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.UserIP })
				.IsUnique(unique: false)
				;
			// **************************************************
			// **************************************************
			// **************************************************
		}
	}
}
