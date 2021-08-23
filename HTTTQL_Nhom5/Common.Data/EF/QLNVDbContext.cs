using Common.Data.Configuration;
using Common.Data.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.EF
{
    public class QLNVDbContext : IdentityDbContext<AppUser , AppRole ,Guid>
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
            modelBuilder.ApplyConfiguration(new DonXinConfiguration());
            modelBuilder.ApplyConfiguration(new KhoaDaoTaoConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietKhoaDaoTaoConfiguration());
            modelBuilder.ApplyConfiguration(new HoSoNhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new PhongBanNhanVienConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<BacLuong> BacLuongs { get; set; }
        public DbSet<BangCap> BangCaps { get; set; }
        public DbSet<ChiTietHopDong> ChiTietHopDongs { get; set; }
        public DbSet<ChiTietKhoaDaoTao> ChiTietKhoaDaoTaos { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<ChucVuNhanVien> ChucVuNhanViens { get; set; }
        public DbSet<CongTy> CongTies { get; set; }
        public DbSet<DonXin> DonXins { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<HoSoNhanVien> HoSoNhanViens { get; set; }
        public DbSet<KhoaDaoTao> KhoaDaoTaos { get; set; }
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<PhongBanNhanVien> PhongBanNhanViens { get; set; }
        public DbSet<PhuCap> PhuCaps { get; set; }
        public DbSet<QuanLy> QuanLies { get; set; }
        public DbSet<QuyetDinhBoNhiem> QuyetDinhBoNhiems { get; set; }
        public DbSet<Thuong> Thuongs { get; set; }




    }
}
