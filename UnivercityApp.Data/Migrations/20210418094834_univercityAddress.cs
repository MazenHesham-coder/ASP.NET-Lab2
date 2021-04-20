using Microsoft.EntityFrameworkCore.Migrations;

namespace UnivercityApp.Data.Migrations
{
    public partial class univercityAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Univercities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Univercities");
        }
    }
}
