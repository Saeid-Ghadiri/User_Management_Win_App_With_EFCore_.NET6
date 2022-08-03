﻿namespace Data.Configurations
{
	internal class UserConfiguration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Aggregates.Users.User>
	{
		public UserConfiguration() : base()
		{
		}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Aggregates.Users.User> builder)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			builder
				.Property(current => current.EmailAddress)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.EmailAddress })
				.IsUnique(unique: true)
				;
			// **************************************************

			// **************************************************
			builder
				.HasIndex(current => new { current.EmailAddressVerificationKey })
				.IsUnique(unique: true)
				;
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.Username)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.Username })
				.IsUnique(unique: true)
				;

			//builder.HasIndex(current => current.Username)
			//	.IsUnique(unique: true)
			//	// HasFilter -> using Microsoft.EntityFrameworkCore;
			//	.HasFilter("[Username] IS NOT NULL");
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.CellPhoneNumber)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.CellPhoneNumber })
				.IsUnique(unique: true)
				;

			//builder.HasIndex(current => current.CellPhoneNumber)
			//	.IsUnique(unique: true)
			//	// HasFilter -> using Microsoft.EntityFrameworkCore;
			//	.HasFilter("[CellPhoneNumber] IS NOT NULL");
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.CellPhoneNumberVerificationKey)
				.IsUnicode(unicode: false)
				;

			builder
				.HasIndex(current => new { current.CellPhoneNumberVerificationKey })
				.IsUnique(unique: true)
				;

			//builder.HasIndex(current => current.CellPhoneNumberVerificationKey)
			//	.IsUnique(unique: true)
			//	// HasFilter -> using Microsoft.EntityFrameworkCore;
			//	.HasFilter("[CellPhoneNumberVerificationKey] IS NOT NULL");
			// **************************************************

			// **************************************************
			builder
				.Property(current => current.Password)
				.IsUnicode(unicode: false)
				;
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			builder
				.HasMany(current => current.UserLogins)
				.WithOne(other => other.User)
				.IsRequired(required: true)
				.HasForeignKey(other => other.UserId)
				.OnDelete(deleteBehavior:
					Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade)
				;
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			//var user =
			//	new Domain.Aggregates.Users.User(emailAddress: "DariushT@GMail.com", roleId: Domain.Role.DefaultRoleId)

			var user =
				new Domain.Aggregates.Users.User(emailAddress: "Ghadiri.saeid@GMail.com")
				{
					//Id,
					//Role,
					//RoleId,
					//EmailAddress,
					//InsertDateTime,
					//UpdateDateTime,
					//EmailAddressVerificationKey
					//CellPhoneNumberVerificationKey,

					Ordering = 0,

					IsActive = true,
					IsSystemic = true,
					IsProgrammer = true,
					IsUndeletable = true,
					IsProfilePublic = true,
					IsEmailAddressVerified = true,
					IsCellPhoneNumberVerified = true,

					Description = null,
					AdminDescription = null,

					Username = "Saeid",
					FullName = "سعید غدیری",
					CellPhoneNumber = "09126898731",

					Password =
						Dtat.Hashing.GetSha256(text: "123"),
				};

			user.SetId(id: Domain.Aggregates.Users.User.SuperUserId);

			builder.HasData(data: user);
			// **************************************************
			// **************************************************
			// **************************************************
		}
	}
}
