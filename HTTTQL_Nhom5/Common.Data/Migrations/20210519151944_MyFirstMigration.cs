using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Data.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BacLuong",
                columns: table => new
                {
                    MaBacLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiLuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MucLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacLuong", x => x.MaBacLuong);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "CongTy",
                columns: table => new
                {
                    MaCongTy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTy", x => x.MaCongTy);
                });

            migrationBuilder.CreateTable(
                name: "HopDong",
                columns: table => new
                {
                    MaHopDong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDong", x => x.MaHopDong);
                });

            migrationBuilder.CreateTable(
                name: "PhuCap",
                columns: table => new
                {
                    MaPhuCap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiPhuCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucPhuCap = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuCap", x => x.MaPhuCap);
                });

            migrationBuilder.CreateTable(
                name: "Thuong",
                columns: table => new
                {
                    MaThuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiThuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucThuong = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thuong", x => x.MaThuong);
                });

            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    MaPhongBan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhongBan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaCongTy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.MaPhongBan);
                    table.ForeignKey(
                        name: "FK_PhongBan_CongTy_MaCongTy",
                        column: x => x.MaCongTy,
                        principalTable: "CongTy",
                        principalColumn: "MaCongTy",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuanLy",
                columns: table => new
                {
                    MaQL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamKinhNghiem = table.Column<double>(type: "float", nullable: false),
                    MaCongTy = table.Column<int>(type: "int", nullable: false),
                    CongTyMaCongTy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanLy", x => x.MaQL);
                    table.ForeignKey(
                        name: "FK_QuanLy_CongTy_CongTyMaCongTy",
                        column: x => x.CongTyMaCongTy,
                        principalTable: "CongTy",
                        principalColumn: "MaCongTy",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaCongTy = table.Column<int>(type: "int", nullable: false),
                    CongTyMaCongTy = table.Column<int>(type: "int", nullable: true),
                    MaPhongBan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK_NhanVien_CongTy_CongTyMaCongTy",
                        column: x => x.CongTyMaCongTy,
                        principalTable: "CongTy",
                        principalColumn: "MaCongTy",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_PhongBan_MaPhongBan",
                        column: x => x.MaPhongBan,
                        principalTable: "PhongBan",
                        principalColumn: "MaPhongBan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BangCap",
                columns: table => new
                {
                    MaBangCap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuyenMon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDaoTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeDaoTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangCap", x => x.MaBangCap);
                    table.ForeignKey(
                        name: "FK_BangCap_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHopDong",
                columns: table => new
                {
                    MaCTHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiHopDong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayKy = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaHopDong = table.Column<int>(type: "int", nullable: false),
                    MaNV = table.Column<int>(type: "int", nullable: false),
                    MaQL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHopDong", x => x.MaCTHD);
                    table.ForeignKey(
                        name: "FK_ChiTietHopDong_HopDong_MaHopDong",
                        column: x => x.MaHopDong,
                        principalTable: "HopDong",
                        principalColumn: "MaHopDong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHopDong_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHopDong_QuanLy_MaQL",
                        column: x => x.MaQL,
                        principalTable: "QuanLy",
                        principalColumn: "MaQL",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChucVuNhanVien",
                columns: table => new
                {
                    MaCVNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayBoNhiem = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaChucVu = table.Column<int>(type: "int", nullable: false),
                    MaNV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVuNhanVien", x => x.MaCVNV);
                    table.ForeignKey(
                        name: "FK_ChucVuNhanVien_ChucVu_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChucVuNhanVien_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Luong",
                columns: table => new
                {
                    MaLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    luong = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    MaNV = table.Column<int>(type: "int", nullable: false),
                    MaPhuCap = table.Column<int>(type: "int", nullable: false),
                    MaBacLuong = table.Column<int>(type: "int", nullable: false),
                    MaThuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luong", x => x.MaLuong);
                    table.ForeignKey(
                        name: "FK_Luong_BacLuong_MaBacLuong",
                        column: x => x.MaBacLuong,
                        principalTable: "BacLuong",
                        principalColumn: "MaBacLuong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Luong_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Luong_PhuCap_MaPhuCap",
                        column: x => x.MaPhuCap,
                        principalTable: "PhuCap",
                        principalColumn: "MaPhuCap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Luong_Thuong_MaThuong",
                        column: x => x.MaThuong,
                        principalTable: "Thuong",
                        principalColumn: "MaThuong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuyetDinhBoNhiem",
                columns: table => new
                {
                    MaQDBN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayBoNhiem = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    MaNV = table.Column<int>(type: "int", nullable: false),
                    MaQL = table.Column<int>(type: "int", nullable: false),
                    MaChucVu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyetDinhBoNhiem", x => x.MaQDBN);
                    table.ForeignKey(
                        name: "FK_QuyetDinhBoNhiem_ChucVu_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuyetDinhBoNhiem_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuyetDinhBoNhiem_QuanLy_MaQL",
                        column: x => x.MaQL,
                        principalTable: "QuanLy",
                        principalColumn: "MaQL",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangCap_MaNV",
                table: "BangCap",
                column: "MaNV");

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

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHopDong_MaQL",
                table: "ChiTietHopDong",
                column: "MaQL");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVuNhanVien_MaChucVu",
                table: "ChucVuNhanVien",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVuNhanVien_MaNV",
                table: "ChucVuNhanVien",
                column: "MaNV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Luong_MaBacLuong",
                table: "Luong",
                column: "MaBacLuong");

            migrationBuilder.CreateIndex(
                name: "IX_Luong_MaNV",
                table: "Luong",
                column: "MaNV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Luong_MaPhuCap",
                table: "Luong",
                column: "MaPhuCap");

            migrationBuilder.CreateIndex(
                name: "IX_Luong_MaThuong",
                table: "Luong",
                column: "MaThuong");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_CongTyMaCongTy",
                table: "NhanVien",
                column: "CongTyMaCongTy");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaPhongBan",
                table: "NhanVien",
                column: "MaPhongBan");

            migrationBuilder.CreateIndex(
                name: "IX_PhongBan_MaCongTy",
                table: "PhongBan",
                column: "MaCongTy");

            migrationBuilder.CreateIndex(
                name: "IX_QuanLy_CongTyMaCongTy",
                table: "QuanLy",
                column: "CongTyMaCongTy");

            migrationBuilder.CreateIndex(
                name: "IX_QuyetDinhBoNhiem_MaChucVu",
                table: "QuyetDinhBoNhiem",
                column: "MaChucVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuyetDinhBoNhiem_MaNV",
                table: "QuyetDinhBoNhiem",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_QuyetDinhBoNhiem_MaQL",
                table: "QuyetDinhBoNhiem",
                column: "MaQL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangCap");

            migrationBuilder.DropTable(
                name: "ChiTietHopDong");

            migrationBuilder.DropTable(
                name: "ChucVuNhanVien");

            migrationBuilder.DropTable(
                name: "Luong");

            migrationBuilder.DropTable(
                name: "QuyetDinhBoNhiem");

            migrationBuilder.DropTable(
                name: "HopDong");

            migrationBuilder.DropTable(
                name: "BacLuong");

            migrationBuilder.DropTable(
                name: "PhuCap");

            migrationBuilder.DropTable(
                name: "Thuong");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "QuanLy");

            migrationBuilder.DropTable(
                name: "PhongBan");

            migrationBuilder.DropTable(
                name: "CongTy");
        }
    }
}
