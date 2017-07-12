using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace darlenyWebApp.Data.Migrations
{
    public partial class Product1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfferID",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitMeasureID",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    OfferID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfferPercent = table.Column<string>(nullable: true),
                    Percent = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.OfferID);
                });

            migrationBuilder.CreateTable(
                name: "UnitMeasure",
                columns: table => new
                {
                    UnitMeasureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Acron = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMeasure", x => x.UnitMeasureID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_OfferID",
                table: "Product",
                column: "OfferID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UnitMeasureID",
                table: "Product",
                column: "UnitMeasureID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Offer_OfferID",
                table: "Product",
                column: "OfferID",
                principalTable: "Offer",
                principalColumn: "OfferID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitMeasure_UnitMeasureID",
                table: "Product",
                column: "UnitMeasureID",
                principalTable: "UnitMeasure",
                principalColumn: "UnitMeasureID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Offer_OfferID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitMeasure_UnitMeasureID",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.DropTable(
                name: "UnitMeasure");

            migrationBuilder.DropIndex(
                name: "IX_Product_OfferID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_UnitMeasureID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "OfferID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UnitMeasureID",
                table: "Product");
        }
    }
}
