----------------------------------------------------------------------------------------------------
Lazy Loading:

(1):

	Install-Package Microsoft.EntityFrameworkCore.Proxies

		Microsoft.EntityFrameworkCore.Proxies

			Castle.Core
			Microsoft.EntityFrameworkCore

(2):

	protected override void OnConfiguring
		(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
	{
		//base.OnConfiguring(optionsBuilder);

		string connectionString = "...";

		optionsBuilder
			.UseLazyLoadingProxies()
			.UseSqlServer(connectionString: connectionString)
			;
		;
	}

(3):

	Note: All navigation properties should have [virtual] keyword!
	Note: All class contains navigation properties should have [public] or [protected] constructor!
----------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------
Nugets:

	Domain (Class Library):

	Persistence (Class Library):

		General:

			<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.11" />

		For Lazy Loading:

			<PackageReference Include="Microsoft.EntityFrameworkCore.Proxies" Version="5.0.11" />

		For Migrations:

			<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="5.0.11">
				<PrivateAssets>all</PrivateAssets>
				<IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
			</PackageReference>


	Application (Startup Project):

		For Migrations:

			<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="5.0.11">
				<PrivateAssets>all</PrivateAssets>
				<IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
			</PackageReference>
----------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------
Note: Below commands should be run for [Persistence]:

Compile -> Without Error(s)!
Tools -> NuGet Package Manager -> Package Manager Console
In Default project -> Select -> [Persistence] class library
Add-Migration InitialMigration
Update-Database
----------------------------------------------------------------------------------------------------
