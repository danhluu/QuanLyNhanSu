using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonXin",
                columns: table => new
                {
                    MaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayViet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonXin", x => x.MaDon);
                    table.ForeignKey(
                        name: "FK_DonXin_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhoaDaoTao",
                columns: table => new
                {
                    MaKhoaDaoTao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GetDate()"),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaNV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaDaoTao", x => x.MaKhoaDaoTao);
                    table.ForeignKey(
                        name: "FK_KhoaDaoTao_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietKhoaDaoTao",
                columns: table => new
                {
                    MaHV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHocVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Truong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaKhoaDaoTao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietKhoaDaoTao", x => x.MaHV);
                    table.ForeignKey(
                        name: "FK_ChiTietKhoaDaoTao_KhoaDaoTao_MaKhoaDaoTao",
                        column: x => x.MaKhoaDaoTao,
                        principalTable: "KhoaDaoTao",
                        principalColumn: "MaKhoaDaoTao",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKhoaDaoTao_MaKhoaDaoTao",
                table: "ChiTietKhoaDaoTao",
                column: "MaKhoaDaoTao");

            migrationBuilder.CreateIndex(
                name: "IX_DonXin_MaNV",
                table: "DonXin",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaDaoTao_MaNV",
                table: "KhoaDaoTao",
                column: "MaNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietKhoaDaoTao");

            migrationBuilder.DropTable(
                name: "DonXin");

            migrationBuilder.DropTable(
                name: "KhoaDaoTao");
        }
    }
}
