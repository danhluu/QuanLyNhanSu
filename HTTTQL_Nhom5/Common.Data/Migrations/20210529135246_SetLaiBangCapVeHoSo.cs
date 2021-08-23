using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class SetLaiBangCapVeHoSo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BangCap_NhanVien_MaNV",
                table: "BangCap");

            migrationBuilder.RenameColumn(
                name: "MaNV",
                table: "BangCap",
                newName: "MaHSNV");

            migrationBuilder.RenameIndex(
                name: "IX_BangCap_MaNV",
                table: "BangCap",
                newName: "IX_BangCap_MaHSNV");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BangCap_HoSoNhanVien_MaHSNV",
                table: "BangCap",
                column: "MaHSNV",
                principalTable: "HoSoNhanVien",
                principalColumn: "MaHSNV",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BangCap_HoSoNhanVien_MaHSNV",
                table: "BangCap");

            migrationBuilder.RenameColumn(
                name: "MaHSNV",
                table: "BangCap",
                newName: "MaNV");

            migrationBuilder.RenameIndex(
                name: "IX_BangCap_MaHSNV",
                table: "BangCap",
                newName: "IX_BangCap_MaNV");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "NhanVien",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_BangCap_NhanVien_MaNV",
                table: "BangCap",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
