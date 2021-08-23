using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class SuaLaiLienKetChiTietHopDongVaHopDong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ChiTietHopDong_MaHopDong",
                table: "ChiTietHopDong");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "DonXin",
                type: "int",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_MaHopDong",
                table: "ChiTietHopDong",
                column: "MaHopDong");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ChiTietHopDong_MaHopDong",
                table: "ChiTietHopDong");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "DonXin",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "0");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_MaHopDong",
                table: "ChiTietHopDong",
                column: "MaHopDong",
                unique: true,
                filter: "[MaHopDong] IS NOT NULL");
        }
    }
}
