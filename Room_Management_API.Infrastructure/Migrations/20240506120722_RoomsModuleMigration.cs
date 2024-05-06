using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Room_Management_API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RoomsModuleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ROOM_FACILITIES",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROOM_FACILITIES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROOM_MEDIAS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    AltText = table.Column<string>(type: "text", nullable: false),
                    Width = table.Column<int>(type: "integer", nullable: false),
                    Height = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROOM_MEDIAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROOM_STATUS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROOM_STATUS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROOM_TYPE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TypeName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROOM_TYPE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROOMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomName = table.Column<string>(type: "text", nullable: false),
                    RoomNumber = table.Column<string>(type: "text", nullable: false),
                    RoomArea = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RoomTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomStatusId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROOMS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ROOMS_ROOM_STATUS_RoomStatusId",
                        column: x => x.RoomStatusId,
                        principalTable: "ROOM_STATUS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ROOMS_ROOM_TYPE_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "ROOM_TYPE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ROOM_FACILITY",
                columns: table => new
                {
                    RoomId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomFacilitiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    RoomsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROOM_FACILITY", x => new { x.RoomId, x.RoomFacilitiesId });
                    table.ForeignKey(
                        name: "FK_ROOM_FACILITY_ROOMS_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "ROOMS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ROOM_FACILITY_ROOM_FACILITIES_RoomFacilitiesId",
                        column: x => x.RoomFacilitiesId,
                        principalTable: "ROOM_FACILITIES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ROOM_MEDIA",
                columns: table => new
                {
                    RoomId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomMediasId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROOM_MEDIA", x => new { x.RoomId, x.RoomMediasId });
                    table.ForeignKey(
                        name: "FK_ROOM_MEDIA_ROOMS_RoomId",
                        column: x => x.RoomId,
                        principalTable: "ROOMS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ROOM_MEDIA_ROOM_MEDIAS_RoomMediasId",
                        column: x => x.RoomMediasId,
                        principalTable: "ROOM_MEDIAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ROOMS_RoomStatusId",
                table: "ROOMS",
                column: "RoomStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ROOMS_RoomTypeId",
                table: "ROOMS",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ROOM_FACILITY_RoomFacilitiesId",
                table: "ROOM_FACILITY",
                column: "RoomFacilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_ROOM_FACILITY_RoomsId",
                table: "ROOM_FACILITY",
                column: "RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_ROOM_MEDIA_RoomMediasId",
                table: "ROOM_MEDIA",
                column: "RoomMediasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ROOM_FACILITY");

            migrationBuilder.DropTable(
                name: "ROOM_MEDIA");

            migrationBuilder.DropTable(
                name: "ROOM_FACILITIES");

            migrationBuilder.DropTable(
                name: "ROOMS");

            migrationBuilder.DropTable(
                name: "ROOM_MEDIAS");

            migrationBuilder.DropTable(
                name: "ROOM_STATUS");

            migrationBuilder.DropTable(
                name: "ROOM_TYPE");
        }
    }
}
