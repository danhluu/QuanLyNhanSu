using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.MaNV);
            builder.Property(x => x.username).IsRequired();
            builder.Property(x => x.password).IsRequired();
            builder.Property(x => x.NgayTao).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.Status).HasDefaultValue(1);
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(x => x.PhongBan).WithMany(y => y.NhanViens).HasForeignKey(z => z.MaPhongBan);
            builder.HasOne(x => x.HoSoNhanVien).WithOne(y => y.NhanVien)
                .HasForeignKey<NhanVien>(z => z.MaHSNV);
        }
    }
}
