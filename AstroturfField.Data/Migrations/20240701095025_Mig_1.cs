using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AstroturfField.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AstroturfFieldOwners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtificialTurfId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AstroturfFieldOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtificialTurfFieldId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtificialTurves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AstroturfFieldOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtificialTurves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtificialTurves_AstroturfFieldOwners_AstroturfFieldOwnerId",
                        column: x => x.AstroturfFieldOwnerId,
                        principalTable: "AstroturfFieldOwners",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtificialTurfId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FootbalEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MatchTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeRange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_ArtificialTurves_ArtificialTurfId",
                        column: x => x.ArtificialTurfId,
                        principalTable: "ArtificialTurves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootbalEquipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootbalEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootbalEquipments_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtificialTurves_AstroturfFieldOwnerId",
                table: "ArtificialTurves",
                column: "AstroturfFieldOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootbalEquipments_ReservationId",
                table: "FootbalEquipments",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ArtificialTurfId",
                table: "Reservations",
                column: "ArtificialTurfId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "FootbalEquipments");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "ArtificialTurves");

            migrationBuilder.DropTable(
                name: "AstroturfFieldOwners");
        }
    }
}
