using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dz10.Migrations
{
    public partial class AddOneToManyAndMantToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AirplaneId",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Tickets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AirplaneId",
                table: "Tickets",
                column: "AirplaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PersonId",
                table: "Tickets",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Airplanes_AirplaneId",
                table: "Tickets",
                column: "AirplaneId",
                principalTable: "Airplanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_People_PersonId",
                table: "Tickets",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Airplanes_AirplaneId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_People_PersonId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_AirplaneId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PersonId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "AirplaneId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Tickets");
        }
    }
}
