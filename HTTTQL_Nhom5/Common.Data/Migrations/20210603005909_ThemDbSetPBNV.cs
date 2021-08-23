using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class ThemDbSetPBNV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhongBanNhanVien_NhanVien_MaNV",
                table: "PhongBanNhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_PhongBanNhanVien_PhongBan_MaPB",
                table: "PhongBanNhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhongBanNhanVien",
                table: "PhongBanNhanVien");

            migrationBuilder.RenameTable(
                name: "PhongBanNhanVien",
                newName: "PhongBanNhanViens");

            migrationBuilder.RenameIndex(
                name: "IX_PhongBanNhanVien_MaPB",
                table: "PhongBanNhanViens",
                newName: "IX_PhongBanNhanViens_MaPB");

            migrationBuilder.RenameIndex(
                name: "IX_PhongBanNhanVien_MaNV",
                table: "PhongBanNhanViens",
                newName: "IX_PhongBanNhanViens_MaNV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhongBanNhanViens",
                table: "PhongBanNhanViens",
                column: "MaPBNV");

            migrationBuilder.AddForeignKey(
                name: "FK_PhongBanNhanViens_NhanVien_MaNV",
                table: "PhongBanNhanViens",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhongBanNhanViens_PhongBan_MaPB",
                table: "PhongBanNhanViens",
                column: "MaPB",
                principalTable: "PhongBan",
                principalColumn: "MaPhongBan",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhongBanNhanViens_NhanVien_MaNV",
                table: "PhongBanNhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_PhongBanNhanViens_PhongBan_MaPB",
                table: "PhongBanNhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhongBanNhanViens",
                table: "PhongBanNhanViens");

            migrationBuilder.RenameTable(
                name: "PhongBanNhanViens",
                newName: "PhongBanNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_PhongBanNhanViens_MaPB",
                table: "PhongBanNhanVien",
                newName: "IX_PhongBanNhanVien_MaPB");

            migrationBuilder.RenameIndex(
                name: "IX_PhongBanNhanViens_MaNV",
                table: "PhongBanNhanVien",
                newName: "IX_PhongBanNhanVien_MaNV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhongBanNhanVien",
                table: "PhongBanNhanVien",
                column: "MaPBNV");

            migrationBuilder.AddForeignKey(
                name: "FK_PhongBanNhanVien_NhanVien_MaNV",
                table: "PhongBanNhanVien",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhongBanNhanVien_PhongBan_MaPB",
                table: "PhongBanNhanVien",
                column: "MaPB",
                principalTable: "PhongBan",
                principalColumn: "MaPhongBan",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
