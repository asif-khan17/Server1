using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ORM_Assignment_2.Migrations
{
    public partial class MigrationAdded_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_updates_products_Pid",
                table: "updates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "products_1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products_1",
                table: "products_1",
                column: "Pid");

            migrationBuilder.AddForeignKey(
                name: "FK_updates_products_1_Pid",
                table: "updates",
                column: "Pid",
                principalTable: "products_1",
                principalColumn: "Pid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_updates_products_1_Pid",
                table: "updates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products_1",
                table: "products_1");

            migrationBuilder.RenameTable(
                name: "products_1",
                newName: "products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Pid");

            migrationBuilder.AddForeignKey(
                name: "FK_updates_products_Pid",
                table: "updates",
                column: "Pid",
                principalTable: "products",
                principalColumn: "Pid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
