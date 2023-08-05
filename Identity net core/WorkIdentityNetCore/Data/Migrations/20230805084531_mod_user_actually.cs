using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkIdentityNetCore.Data.Migrations
{
    public partial class mod_user_actually : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodiceFiscale",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodiceFiscale",
                table: "AspNetUsers");
        }
    }
}
