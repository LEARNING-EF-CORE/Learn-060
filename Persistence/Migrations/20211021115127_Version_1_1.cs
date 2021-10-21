using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
	public partial class Version_1_1 : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			//migrationBuilder.DeleteData(
			//	table: "Users",
			//	keyColumn: "Id",
			//	keyValue: new Guid("95944991-15d0-4265-8ac5-08da0fa15182"));

			//migrationBuilder.DeleteData(
			//	table: "Users",
			//	keyColumn: "Id",
			//	keyValue: new Guid("96d2e79e-78c0-43a7-8f65-6ed483774331"));

			migrationBuilder.AddColumn<string>(
				name: "FName",
				table: "Users",
				type: "nvarchar(100)",
				maxLength: 100,
				nullable: true);

			//migrationBuilder.InsertData(
			//	table: "Users",
			//	columns: new[] { "Id", "FName", "Username" },
			//	values: new object[] { new Guid("acde1e41-6dfb-463f-b533-28335b1e6fd5"), null, "Ahmad" });

			//migrationBuilder.InsertData(
			//	table: "Users",
			//	columns: new[] { "Id", "FName", "Username" },
			//	values: new object[] { new Guid("827333bc-386f-422f-bb82-29db580c9371"), null, "Akbar" });
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			//migrationBuilder.DeleteData(
			//	table: "Users",
			//	keyColumn: "Id",
			//	keyValue: new Guid("827333bc-386f-422f-bb82-29db580c9371"));

			//migrationBuilder.DeleteData(
			//	table: "Users",
			//	keyColumn: "Id",
			//	keyValue: new Guid("acde1e41-6dfb-463f-b533-28335b1e6fd5"));

			migrationBuilder.DropColumn(
				name: "FName",
				table: "Users");

			//migrationBuilder.InsertData(
			//	table: "Users",
			//	columns: new[] { "Id", "Username" },
			//	values: new object[] { new Guid("96d2e79e-78c0-43a7-8f65-6ed483774331"), "Ahmad" });

			//migrationBuilder.InsertData(
			//	table: "Users",
			//	columns: new[] { "Id", "Username" },
			//	values: new object[] { new Guid("95944991-15d0-4265-8ac5-08da0fa15182"), "Akbar" });
		}
	}
}
