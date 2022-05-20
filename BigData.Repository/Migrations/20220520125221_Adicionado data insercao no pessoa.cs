using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BigData.Repository.Migrations
{
    public partial class Adicionadodatainsercaonopessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataInsercao",
                table: "Pessoa",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataInsercao",
                table: "Pessoa");
        }
    }
}
