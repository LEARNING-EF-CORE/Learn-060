using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
	public partial class Version_1_2 : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			//migrationBuilder.DeleteData(
			//	table: "Users",
			//	keyColumn: "Id",
			//	keyValue: new Guid("827333bc-386f-422f-bb82-29db580c9371"));

			//migrationBuilder.DeleteData(
			//	table: "Users",
			//	keyColumn: "Id",
			//	keyValue: new Guid("acde1e41-6dfb-463f-b533-28335b1e6fd5"));

			migrationBuilder.RenameColumn(
				name: "FName",
				table: "Users",
				newName: "FullName");

			//migrationBuilder.InsertData(
			//	table: "Users",
			//	columns: new[] { "Id", "FullName", "Username" },
			//	values: new object[] { new Guid("243c95d9-69de-4db2-931f-b80a3f6d2319"), null, "Ahmad" });

			//migrationBuilder.InsertData(
			//	table: "Users",
			//	columns: new[] { "Id", "FullName", "Username" },
			//	values: new object[] { new Guid("5acb72a7-1ff6-403d-85a2-7e0d1bbcd758"), null, "Akbar" });
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			//migrationBuilder.DeleteData(
			//	table: "Users",
			//	keyColumn: "Id",
			//	keyValue: new Guid("243c95d9-69de-4db2-931f-b80a3f6d2319"));

			//migrationBuilder.DeleteData(
			//	table: "Users",
			//	keyColumn: "Id",
			//	keyValue: new Guid("5acb72a7-1ff6-403d-85a2-7e0d1bbcd758"));

			migrationBuilder.RenameColumn(
				name: "FullName",
				table: "Users",
				newName: "FName");

			//migrationBuilder.InsertData(
			//	table: "Users",
			//	columns: new[] { "Id", "FName", "Username" },
			//	values: new object[] { new Guid("acde1e41-6dfb-463f-b533-28335b1e6fd5"), null, "Ahmad" });

			//migrationBuilder.InsertData(
			//	table: "Users",
			//	columns: new[] { "Id", "FName", "Username" },
			//	values: new object[] { new Guid("827333bc-386f-422f-bb82-29db580c9371"), null, "Akbar" });
		}
	}
}
