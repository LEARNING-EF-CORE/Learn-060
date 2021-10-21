namespace Domain.Aggregates.Users
{
	public class User : SeedWork.Entity
	{
		public const int UsernameMaxLength = 20;
		public const int FullNameMaxLength = 100;

		public User() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Username))]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages.Validator),
			ErrorMessageResourceName = nameof(Resources.Messages.Validator.Required))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: UsernameMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validator),
			ErrorMessageResourceName = nameof(Resources.Messages.Validator.MaxLength))]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.FullName))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: FullNameMaxLength,
			ErrorMessageResourceType = typeof(Resources.Messages.Validator),
			ErrorMessageResourceName = nameof(Resources.Messages.Validator.MaxLength))]
		public string FullName { get; set; }
		// **********
	}
}
