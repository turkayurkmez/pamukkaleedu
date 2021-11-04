using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pamukkaleEdu.Data.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeorikSure = table.Column<int>(type: "int", nullable: true),
                    PratikSure = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Program = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgrencilerDersler",
                columns: table => new
                {
                    DersId = table.Column<int>(type: "int", nullable: false),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    Notu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrencilerDersler", x => new { x.DersId, x.OgrenciId });
                    table.ForeignKey(
                        name: "FK_OgrencilerDersler_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrencilerDersler_Ogrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "Id", "Ad", "PratikSure", "TeorikSure" },
                values: new object[,]
                {
                    { 1, "Epistemoloji", null, null },
                    { 2, "Fizik", null, null },
                    { 3, "Matematik", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ogrenciler",
                columns: new[] { "Id", "Ad", "DogumTarihi", "Durum", "GuncellemeTarihi", "OgrenciNo", "OlusturulmaTarihi", "Program", "Soyad" },
                values: new object[,]
                {
                    { 1, "Türkay", null, null, null, "202100001", null, null, "Ürkmez" },
                    { 2, "Ahmet", null, null, null, "202100002", null, null, "Dayıoğlu" }
                });

            migrationBuilder.InsertData(
                table: "OgrencilerDersler",
                columns: new[] { "DersId", "OgrenciId", "Notu" },
                values: new object[,]
                {
                    { 1, 1, null },
                    { 3, 1, null },
                    { 2, 2, null },
                    { 3, 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrencilerDersler_OgrenciId",
                table: "OgrencilerDersler",
                column: "OgrenciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgrencilerDersler");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");
        }
    }
}
