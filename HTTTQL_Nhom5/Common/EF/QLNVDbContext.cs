using Common.Configuration;
using Common.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.EF
{
    public class QLNVDbContext : DbContext
    {
        public QLNVDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BacLuongConfiguration());
            modelBuilder.ApplyConfiguration(new BangCapConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietHopDongConfiguration());
            modelBuilder.ApplyConfiguration(new ChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new ChucVuNhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new CongTyConfiguration());
            modelBuilder.ApplyConfiguration(new HopDongConfiguration());
            modelBuilder.ApplyConfiguration(new LuongConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new PhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new PhuCapConfiguration());
            modelBuilder.ApplyConfiguration(new QuanLyConfiguration());
            modelBuilder.ApplyConfiguration(new QuyetDinhBoNhiemConfiguration());
            modelBuilder.ApplyConfiguration(new ThuongConfiguration());
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<BacLuong> BacLuongs { get; set; }
        public DbSet<BangCap> BangCaps { get; set; }
        public DbSet<ChiTietHopDong> ChiTietHopDongs { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<ChucVuNhanVien> ChucVuNhanViens { get; set; }
        public DbSet<CongTy> CongTies { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<PhuCap> PhuCaps { get; set; }
        public DbSet<QuanLy> QuanLies { get; set; }
        public DbSet<QuyetDinhBoNhiem> QuyetDinhBoNhiems { get; set; }
        public DbSet<Thuong> Thuongs { get; set; }



    }
}
