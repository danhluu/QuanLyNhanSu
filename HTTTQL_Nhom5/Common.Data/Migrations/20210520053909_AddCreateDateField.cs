using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class AddCreateDateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BangCap_NhanVien_MaNV",
                table: "BangCap");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHopDong_HopDong_MaHopDong",
                table: "ChiTietHopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHopDong_NhanVien_MaNV",
                table: "ChiTietHopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHopDong_QuanLy_MaQL",
                table: "ChiTietHopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_ChucVuNhanVien_ChucVu_MaChucVu",
                table: "ChucVuNhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_ChucVuNhanVien_NhanVien_MaNV",
                table: "ChucVuNhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_Luong_BacLuong_MaBacLuong",
                table: "Luong");

            migrationBuilder.DropForeignKey(
                name: "FK_Luong_NhanVien_MaNV",
                table: "Luong");

            migrationBuilder.DropForeignKey(
                name: "FK_Luong_PhuCap_MaPhuCap",
                table: "Luong");

            migrationBuilder.DropForeignKey(
                name: "FK_Luong_Thuong_MaThuong",
                table: "Luong");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_PhongBan_MaPhongBan",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_PhongBan_CongTy_MaCongTy",
                table: "PhongBan");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyetDinhBoNhiem_ChucVu_MaChucVu",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyetDinhBoNhiem_NhanVien_MaNV",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyetDinhBoNhiem_QuanLy_MaQL",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.DropIndex(
                name: "IX_QuyetDinhBoNhiem_MaChucVu",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.DropIndex(
                name: "IX_Luong_MaNV",
                table: "Luong");

            migrationBuilder.DropIndex(
                name: "IX_ChucVuNhanVien_MaNV",
                table: "ChucVuNhanVien");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHopDong_MaHopDong",
                table: "ChiTietHopDong");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHopDong_MaNV",
                table: "ChiTietHopDong");

            migrationBuilder.AlterColumn<int>(
                name: "MucThuong",
                table: "Thuong",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "Thuong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Thuong",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBoNhiem",
                table: "QuyetDinhBoNhiem",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<int>(
                name: "MaQL",
                table: "QuyetDinhBoNhiem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "QuyetDinhBoNhiem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaChucVu",
                table: "QuyetDinhBoNhiem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "QuanLy",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<double>(
                name: "NamKinhNghiem",
                table: "QuanLy",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "MaCongTy",
                table: "QuanLy",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "QuanLy",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "QuanLy",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<int>(
                name: "Quyen",
                table: "QuanLy",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MucPhuCap",
                table: "PhuCap",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "PhuCap",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "PhuCap",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<int>(
                name: "MaCongTy",
                table: "PhongBan",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "PhongBan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "PhongBan",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "NhanVien",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "MaPhongBan",
                table: "NhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaCongTy",
                table: "NhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "NhanVien",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "NhanVien",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "luong",
                table: "Luong",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MaThuong",
                table: "Luong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaPhuCap",
                table: "Luong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "Luong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaBacLuong",
                table: "Luong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "Luong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Luong",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "HopDong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "HopDong",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBoNhiem",
                table: "ChucVuNhanVien",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "ChucVuNhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaChucVu",
                table: "ChucVuNhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "ChucVuNhanVien",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "ChucVu",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "ChucVu",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayKy",
                table: "ChiTietHopDong",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayKetThuc",
                table: "ChiTietHopDong",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "MaQL",
                table: "ChiTietHopDong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "ChiTietHopDong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaHopDong",
                table: "ChiTietHopDong",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "ChiTietHopDong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "ChiTietHopDong",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "BangCap",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "BangCap",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "BangCap",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySua",
                table: "BacLuong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "BacLuong",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.CreateIndex(
                name: "IX_QuyetDinhBoNhiem_MaChucVu",
                table: "QuyetDinhBoNhiem",
                column: "MaChucVu",
                unique: true,
                filter: "[MaChucVu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Luong_MaNV",
                table: "Luong",
                column: "MaNV",
                unique: true,
                filter: "[MaNV] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVuNhanVien_MaNV",
                table: "ChucVuNhanVien",
                column: "MaNV",
                unique: true,
                filter: "[MaNV] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_MaHopDong",
                table: "ChiTietHopDong",
                column: "MaHopDong",
                unique: true,
                filter: "[MaHopDong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_MaNV",
                table: "ChiTietHopDong",
                column: "MaNV",
                unique: true,
                filter: "[MaNV] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BangCap_NhanVien_MaNV",
                table: "BangCap",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHopDong_HopDong_MaHopDong",
                table: "ChiTietHopDong",
                column: "MaHopDong",
                principalTable: "HopDong",
                principalColumn: "MaHopDong",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHopDong_NhanVien_MaNV",
                table: "ChiTietHopDong",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHopDong_QuanLy_MaQL",
                table: "ChiTietHopDong",
                column: "MaQL",
                principalTable: "QuanLy",
                principalColumn: "MaQL",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChucVuNhanVien_ChucVu_MaChucVu",
                table: "ChucVuNhanVien",
                column: "MaChucVu",
                principalTable: "ChucVu",
                principalColumn: "MaChucVu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChucVuNhanVien_NhanVien_MaNV",
                table: "ChucVuNhanVien",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Luong_BacLuong_MaBacLuong",
                table: "Luong",
                column: "MaBacLuong",
                principalTable: "BacLuong",
                principalColumn: "MaBacLuong",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Luong_NhanVien_MaNV",
                table: "Luong",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Luong_PhuCap_MaPhuCap",
                table: "Luong",
                column: "MaPhuCap",
                principalTable: "PhuCap",
                principalColumn: "MaPhuCap",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Luong_Thuong_MaThuong",
                table: "Luong",
                column: "MaThuong",
                principalTable: "Thuong",
                principalColumn: "MaThuong",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_PhongBan_MaPhongBan",
                table: "NhanVien",
                column: "MaPhongBan",
                principalTable: "PhongBan",
                principalColumn: "MaPhongBan",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhongBan_CongTy_MaCongTy",
                table: "PhongBan",
                column: "MaCongTy",
                principalTable: "CongTy",
                principalColumn: "MaCongTy",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyetDinhBoNhiem_ChucVu_MaChucVu",
                table: "QuyetDinhBoNhiem",
                column: "MaChucVu",
                principalTable: "ChucVu",
                principalColumn: "MaChucVu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyetDinhBoNhiem_NhanVien_MaNV",
                table: "QuyetDinhBoNhiem",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyetDinhBoNhiem_QuanLy_MaQL",
                table: "QuyetDinhBoNhiem",
                column: "MaQL",
                principalTable: "QuanLy",
                principalColumn: "MaQL",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BangCap_NhanVien_MaNV",
                table: "BangCap");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHopDong_HopDong_MaHopDong",
                table: "ChiTietHopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHopDong_NhanVien_MaNV",
                table: "ChiTietHopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHopDong_QuanLy_MaQL",
                table: "ChiTietHopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_ChucVuNhanVien_ChucVu_MaChucVu",
                table: "ChucVuNhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_ChucVuNhanVien_NhanVien_MaNV",
                table: "ChucVuNhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_Luong_BacLuong_MaBacLuong",
                table: "Luong");

            migrationBuilder.DropForeignKey(
                name: "FK_Luong_NhanVien_MaNV",
                table: "Luong");

            migrationBuilder.DropForeignKey(
                name: "FK_Luong_PhuCap_MaPhuCap",
                table: "Luong");

            migrationBuilder.DropForeignKey(
                name: "FK_Luong_Thuong_MaThuong",
                table: "Luong");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_PhongBan_MaPhongBan",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_PhongBan_CongTy_MaCongTy",
                table: "PhongBan");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyetDinhBoNhiem_ChucVu_MaChucVu",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyetDinhBoNhiem_NhanVien_MaNV",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyetDinhBoNhiem_QuanLy_MaQL",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.DropIndex(
                name: "IX_QuyetDinhBoNhiem_MaChucVu",
                table: "QuyetDinhBoNhiem");

            migrationBuilder.DropIndex(
                name: "IX_Luong_MaNV",
                table: "Luong");

            migrationBuilder.DropIndex(
                name: "IX_ChucVuNhanVien_MaNV",
                table: "ChucVuNhanVien");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHopDong_MaHopDong",
                table: "ChiTietHopDong");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHopDong_MaNV",
                table: "ChiTietHopDong");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "Thuong");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Thuong");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "QuanLy");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "QuanLy");

            migrationBuilder.DropColumn(
                name: "Quyen",
                table: "QuanLy");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "PhuCap");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "PhuCap");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "PhongBan");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "PhongBan");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "Luong");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Luong");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "ChucVuNhanVien");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "ChucVu");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "ChucVu");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "ChiTietHopDong");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "ChiTietHopDong");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "BangCap");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "BangCap");

            migrationBuilder.DropColumn(
                name: "NgaySua",
                table: "BacLuong");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "BacLuong");

            migrationBuilder.AlterColumn<int>(
                name: "MucThuong",
                table: "Thuong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBoNhiem",
                table: "QuyetDinhBoNhiem",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<int>(
                name: "MaQL",
                table: "QuyetDinhBoNhiem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "QuyetDinhBoNhiem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaChucVu",
                table: "QuyetDinhBoNhiem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "QuanLy",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "NamKinhNghiem",
                table: "QuanLy",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaCongTy",
                table: "QuanLy",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MucPhuCap",
                table: "PhuCap",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MaCongTy",
                table: "PhongBan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaPhongBan",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaCongTy",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "luong",
                table: "Luong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MaThuong",
                table: "Luong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaPhuCap",
                table: "Luong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "Luong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaBacLuong",
                table: "Luong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayBoNhiem",
                table: "ChucVuNhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "ChucVuNhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaChucVu",
                table: "ChucVuNhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayKy",
                table: "ChiTietHopDong",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayKetThuc",
                table: "ChiTietHopDong",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaQL",
                table: "ChiTietHopDong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "ChiTietHopDong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaHopDong",
                table: "ChiTietHopDong",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaNV",
                table: "BangCap",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuyetDinhBoNhiem_MaChucVu",
                table: "QuyetDinhBoNhiem",
                column: "MaChucVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Luong_MaNV",
                table: "Luong",
                column: "MaNV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChucVuNhanVien_MaNV",
                table: "ChucVuNhanVien",
                column: "MaNV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_MaHopDong",
                table: "ChiTietHopDong",
                column: "MaHopDong",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_MaNV",
                table: "ChiTietHopDong",
                column: "MaNV",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BangCap_NhanVien_MaNV",
                table: "BangCap",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHopDong_HopDong_MaHopDong",
                table: "ChiTietHopDong",
                column: "MaHopDong",
                principalTable: "HopDong",
                principalColumn: "MaHopDong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHopDong_NhanVien_MaNV",
                table: "ChiTietHopDong",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHopDong_QuanLy_MaQL",
                table: "ChiTietHopDong",
                column: "MaQL",
                principalTable: "QuanLy",
                principalColumn: "MaQL",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChucVuNhanVien_ChucVu_MaChucVu",
                table: "ChucVuNhanVien",
                column: "MaChucVu",
                principalTable: "ChucVu",
                principalColumn: "MaChucVu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChucVuNhanVien_NhanVien_MaNV",
                table: "ChucVuNhanVien",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Luong_BacLuong_MaBacLuong",
                table: "Luong",
                column: "MaBacLuong",
                principalTable: "BacLuong",
                principalColumn: "MaBacLuong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Luong_NhanVien_MaNV",
                table: "Luong",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Luong_PhuCap_MaPhuCap",
                table: "Luong",
                column: "MaPhuCap",
                principalTable: "PhuCap",
                principalColumn: "MaPhuCap",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Luong_Thuong_MaThuong",
                table: "Luong",
                column: "MaThuong",
                principalTable: "Thuong",
                principalColumn: "MaThuong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_PhongBan_MaPhongBan",
                table: "NhanVien",
                column: "MaPhongBan",
                principalTable: "PhongBan",
                principalColumn: "MaPhongBan",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhongBan_CongTy_MaCongTy",
                table: "PhongBan",
                column: "MaCongTy",
                principalTable: "CongTy",
                principalColumn: "MaCongTy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyetDinhBoNhiem_ChucVu_MaChucVu",
                table: "QuyetDinhBoNhiem",
                column: "MaChucVu",
                principalTable: "ChucVu",
                principalColumn: "MaChucVu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyetDinhBoNhiem_NhanVien_MaNV",
                table: "QuyetDinhBoNhiem",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyetDinhBoNhiem_QuanLy_MaQL",
                table: "QuyetDinhBoNhiem",
                column: "MaQL",
                principalTable: "QuanLy",
                principalColumn: "MaQL",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
