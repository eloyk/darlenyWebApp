using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace darlenyWebApp.Data.Migrations
{
    public partial class ApplicationDbContextModelSnapshot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Product");
        }
    }
}
