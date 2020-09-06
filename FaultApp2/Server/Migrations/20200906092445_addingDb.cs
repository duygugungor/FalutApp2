using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FaultApp2.Server.Migrations
{
    public partial class addingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakinaGrubu = table.Column<string>(nullable: false),
                    Makina = table.Column<string>(nullable: true),
                    Operator = table.Column<string>(nullable: true),
                    RecordTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    FixedTime = table.Column<DateTime>(nullable: false),
                    FixDescription = table.Column<string>(nullable: true),
                    FixBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faults", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faults");
        }
    }
}
