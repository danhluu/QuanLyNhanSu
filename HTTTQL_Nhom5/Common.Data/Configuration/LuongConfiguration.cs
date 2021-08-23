using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class LuongConfiguration : IEntityTypeConfiguration<Luong>
    {
        public void Configure(EntityTypeBuilder<Luong> builder)
        {
            builder.ToTable("Luong");
            builder.HasKey(x => x.MaLuong);
            builder.Property(x => x.luong).HasDefaultValue(0);
            builder.Property(x => x.NgayTao).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(x => x.PhuCap).WithMany(y => y.Luongs).HasForeignKey(z => z.MaPhuCap);
            builder.HasOne(x => x.Thuong).WithMany(y => y.Luongs).HasForeignKey(z => z.MaThuong);
            builder.HasOne(x => x.BacLuong).WithMany(y => y.Luongs).HasForeignKey(z => z.MaBacLuong);
            builder.HasOne(x => x.NhanVien).WithMany(y => y.Luong).HasForeignKey(z => z.MaNV);
        }
    }
}
