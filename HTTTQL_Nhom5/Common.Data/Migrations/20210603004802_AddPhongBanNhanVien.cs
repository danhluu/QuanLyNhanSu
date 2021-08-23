using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class AddPhongBanNhanVien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongBanNhanVien",
                columns: table => new
                {
                    MaPBNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPB = table.Column<int>(type: "int", nullable: true),
                    TenPhongBan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNV = table.Column<int>(type: "int", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayChuyen = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GetDate()"),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHide = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBanNhanVien", x => x.MaPBNV);
                    table.ForeignKey(
                        name: "FK_PhongBanNhanVien_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhongBanNhanVien_PhongBan_MaPB",
                        column: x => x.MaPB,
                        principalTable: "PhongBan",
                        principalColumn: "MaPhongBan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhongBanNhanVien_MaNV",
                table: "PhongBanNhanVien",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_PhongBanNhanVien_MaPB",
                table: "PhongBanNhanVien",
                column: "MaPB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhongBanNhanVien");
        }
    }
}
