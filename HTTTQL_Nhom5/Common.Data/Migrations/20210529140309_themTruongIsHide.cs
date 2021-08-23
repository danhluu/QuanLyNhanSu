using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class themTruongIsHide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "Thuong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "QuyetDinhBoNhiem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "QuanLy",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "PhuCap",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "PhongBan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "NhanVien",
                type: "int",
                nullable: true,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "Luong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "KhoaDaoTao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "HoSoNhanVien",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "HopDong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "DonXin",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "CongTy",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "ChucVuNhanVien",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "ChucVu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "ChiTietKhoaDaoTao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "ChiTietHopDong",
                type: "int",
                nullable: true,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "BangCap",
                type: "int",
                nullable: true,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<int>(
                name: "IsHide",
                table: "BacLuong",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "Thuong");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "QuanLy");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "PhuCap");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "PhongBan");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "Luong");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "KhoaDaoTao");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "HoSoNhanVien");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "DonXin");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "CongTy");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "ChucVuNhanVien");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "ChucVu");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "ChiTietKhoaDaoTao");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "ChiTietHopDong");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "BangCap");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "BacLuong");
        }
    }
}
