using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class SuaQuyetDinhBoNhiem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QuyetDinhBoNhiem_MaChucVu",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.CreateIndex(
                name: "IX_QuyetDinhBoNhiem_MaChucVu",
                table: "QuyetDinhBoNhiem",
                column: "MaChucVu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QuyetDinhBoNhiem_MaChucVu",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.CreateIndex(
                name: "IX_QuyetDinhBoNhiem_MaChucVu",
                table: "QuyetDinhBoNhiem",
                column: "MaChucVu",
                unique: true,
                filter: "[MaChucVu] IS NOT NULL");
        }
    }
}
