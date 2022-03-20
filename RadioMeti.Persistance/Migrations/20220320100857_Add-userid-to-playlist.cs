﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadioMeti.Persistance.Migrations
{
    public partial class Adduseridtoplaylist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PlayLists",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayLists_UserId",
                table: "PlayLists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayLists_AspNetUsers_UserId",
                table: "PlayLists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayLists_AspNetUsers_UserId",
                table: "PlayLists");

            migrationBuilder.DropIndex(
                name: "IX_PlayLists_UserId",
                table: "PlayLists");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PlayLists");
        }
    }
}
