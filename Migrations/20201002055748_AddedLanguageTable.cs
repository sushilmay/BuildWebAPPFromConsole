﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildWebAPPFromConsole.Migrations
{
    public partial class AddedLanguageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    Description = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_LanguageId",
                table: "Books",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_language_LanguageId",
                table: "Books",
                column: "LanguageId",
                principalTable: "language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_language_LanguageId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropIndex(
                name: "IX_Books_LanguageId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
