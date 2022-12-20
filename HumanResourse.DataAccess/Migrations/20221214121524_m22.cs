using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResourse.DataAccess.Migrations
{
    public partial class m22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestOfPermitDay",
                table: "Permits",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestOfPermitDay",
                table: "Permits");
        }
    }
}
