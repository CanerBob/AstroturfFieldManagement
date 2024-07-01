using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    AstroturfFieldOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtificialTurves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtificialTurves_AstroturfFieldOwners_AstroturfFieldOwnerId",
                        column: x => x.AstroturfFieldOwnerId,
                        principalTable: "AstroturfFieldOwners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtificialTurves_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "AstroturfFieldOwners",
                columns: new[] { "Id", "ArtificialTurfId", "FullName", "IsActive", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("58b71aa4-80ed-4d76-a062-8cee2bbe4928"), new Guid("164d108a-cbb3-4e5e-9b47-a43738d2c5b1"), "Caner Bayraktar", true, "1234567890" },
                    { new Guid("829820ed-d1ff-4995-b7bf-3ad6983ff0cd"), new Guid("d7209b6c-1b0a-49f4-b181-fc155585a948"), "Caner Bayraktar", true, "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "ArtificialTurfFieldId", "Name" },
                values: new object[,]
                {
                    { new Guid("afb580e1-ab0d-40d1-a26e-8fb443ddac76"), new Guid("4b90104a-5d36-44c6-8261-9c59b1653ff4"), "Eskişehir" },
                    { new Guid("c3d8a7f4-5137-4bd3-a52e-4db8ed951fd8"), new Guid("164d108a-cbb3-4e5e-9b47-a43738d2c5b1"), "Bilecik" }
                });

            migrationBuilder.InsertData(
                table: "FootbalEquipments",
                columns: new[] { "Id", "IsActive", "Name", "ReservationId" },
                values: new object[,]
                {
                    { new Guid("5e8f0707-a9fc-4e1f-a4d9-7966ad1d74bd"), true, "Krampon", null },
                    { new Guid("7fbdfa79-100f-4b0c-88d6-1ca94bbc139b"), true, "Kaleci Eldiveni", null }
                });

            migrationBuilder.InsertData(
                table: "ArtificialTurves",
                columns: new[] { "Id", "Adress", "AstroturfFieldOwnerId", "CityId", "CreatedDate", "District", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("164d108a-cbb3-4e5e-9b47-a43738d2c5b1"), "Sanayinin Girişi", new Guid("58b71aa4-80ed-4d76-a062-8cee2bbe4928"), new Guid("c3d8a7f4-5137-4bd3-a52e-4db8ed951fd8"), new DateTime(2024, 7, 1, 12, 5, 53, 34, DateTimeKind.Utc).AddTicks(6169), "Merkez", true, "Gökkaya" },
                    { new Guid("d7209b6c-1b0a-49f4-b181-fc155585a948"), "Sanayinin Sonu", new Guid("829820ed-d1ff-4995-b7bf-3ad6983ff0cd"), new Guid("afb580e1-ab0d-40d1-a26e-8fb443ddac76"), new DateTime(2024, 7, 1, 12, 5, 53, 34, DateTimeKind.Utc).AddTicks(6176), "Merkez", true, "Kardeşler" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtificialTurves_AstroturfFieldOwnerId",
                table: "ArtificialTurves",
                column: "AstroturfFieldOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtificialTurves_CityId",
                table: "ArtificialTurves",
                column: "CityId");

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
                name: "FootbalEquipments");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "ArtificialTurves");

            migrationBuilder.DropTable(
                name: "AstroturfFieldOwners");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
