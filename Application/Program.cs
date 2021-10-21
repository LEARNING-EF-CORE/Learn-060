//using System.Linq;
//using Microsoft.EntityFrameworkCore;

namespace Application
{
	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			CreateUser();
		}

		public static void CreateUser()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var user1 =
					new Domain.Aggregates.Users.User
					{
						Username = "Dariush",
					};

				databaseContext.Users.Add(user1);

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	}
}
