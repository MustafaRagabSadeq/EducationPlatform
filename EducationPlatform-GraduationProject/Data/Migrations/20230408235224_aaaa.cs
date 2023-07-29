﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationPlatform_GraduationProject.Data.Migrations
{
    public partial class aaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_UserIdentityId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserIdentityId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UserIdentityId",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserIdentityId",
                table: "Students",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserIdentityId",
                table: "Students",
                column: "UserIdentityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_UserIdentityId",
                table: "Students",
                column: "UserIdentityId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
