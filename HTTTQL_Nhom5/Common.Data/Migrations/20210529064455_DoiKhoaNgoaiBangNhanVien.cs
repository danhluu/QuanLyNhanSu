using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class DoiKhoaNgoaiBangNhanVien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoSoNhanVien_NhanVien_MaNV",
                table: "HoSoNhanVien");

            migrationBuilder.DropIndex(
                name: "IX_HoSoNhanVien_MaNV",
                table: "HoSoNhanVien");

            migrationBuilder.DropColumn(
                name: "MaNV",
                table: "HoSoNhanVien");

            migrationBuilder.AddColumn<int>(
                name: "MaHSNV",
                table: "NhanVien",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaHSNV",
                table: "NhanVien",
                column: "MaHSNV",
                unique: true,
                filter: "[MaHSNV] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_HoSoNhanVien_MaHSNV",
                table: "NhanVien",
                column: "MaHSNV",
                principalTable: "HoSoNhanVien",
                principalColumn: "MaHSNV",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_HoSoNhanVien_MaHSNV",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_MaHSNV",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "MaHSNV",
                table: "NhanVien");

            migrationBuilder.AddColumn<int>(
                name: "MaNV",
                table: "HoSoNhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HoSoNhanVien_MaNV",
                table: "HoSoNhanVien",
                column: "MaNV",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HoSoNhanVien_NhanVien_MaNV",
                table: "HoSoNhanVien",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
