using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
	public partial class InitialMigration : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Users",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Users", x => x.Id);
				});

			migrationBuilder.InsertData(
				table: "Users",
				columns: new[] { "Id", "Username" },
				values: new object[] { new Guid("96d2e79e-78c0-43a7-8f65-6ed483774331"), "Ahmad" });

			migrationBuilder.InsertData(
				table: "Users",
				columns: new[] { "Id", "Username" },
				values: new object[] { new Guid("95944991-15d0-4265-8ac5-08da0fa15182"), "Akbar" });

			migrationBuilder.CreateIndex(
				name: "IX_Users_Username",
				table: "Users",
				column: "Username",
				unique: true);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Users");
		}
	}
}
