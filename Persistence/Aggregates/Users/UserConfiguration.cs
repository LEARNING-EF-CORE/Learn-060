namespace Persistence.Aggregates.Users
{
	internal class UserConfiguration : object,
		Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Aggregates.Users.User>
	{
		public UserConfiguration() : base()
		{
		}

		public void Configure
			(Microsoft.EntityFrameworkCore.Metadata.Builders
			.EntityTypeBuilder<Domain.Aggregates.Users.User> builder)
		{
			// **************************************************
			builder
				.HasIndex(current => current.Username)
				.IsUnique(unique: true)
				;
			// **************************************************

			Domain.Aggregates.Users.User newUser = null;

			// **************************************************
			newUser =
				new Domain.Aggregates.Users.User
				{
					Username = "Ahmad",
				};

			builder.HasData(newUser);

			newUser =
				new Domain.Aggregates.Users.User
				{
					Username = "Akbar",
				};

			builder.HasData(newUser);
			// **************************************************
		}
	}
}
