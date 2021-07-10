using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Com.Data.Migrations
{
    public partial class ECom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    categorieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categorieName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.categorieID);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    articleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    articleName = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    stock = table.Column<int>(nullable: false),
                    prix = table.Column<decimal>(nullable: false),
                    categorieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.articleID);
                    table.ForeignKey(
                        name: "FK_Article_Categorie_categorieID",
                        column: x => x.categorieID,
                        principalTable: "Categorie",
                        principalColumn: "categorieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    commandeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateCommande = table.Column<DateTime>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    quantite = table.Column<int>(nullable: false),
                    articleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.commandeID);
                    table.ForeignKey(
                        name: "FK_Commande_Article_articleID",
                        column: x => x.articleID,
                        principalTable: "Article",
                        principalColumn: "articleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_categorieID",
                table: "Article",
                column: "categorieID");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_articleID",
                table: "Commande",
                column: "articleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}
