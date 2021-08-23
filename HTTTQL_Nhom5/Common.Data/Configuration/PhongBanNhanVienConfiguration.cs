using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class PhongBanNhanVienConfiguration : IEntityTypeConfiguration<PhongBanNhanVien>
    {
        public void Configure(EntityTypeBuilder<PhongBanNhanVien> builder)
        {
            builder.HasKey(x => x.MaPBNV);
            builder.Property(x => x.NgayChuyen).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(x => x.PhongBan).WithMany(y => y.PhongBanNhanViens).HasForeignKey(z => z.MaPB);
            builder.HasOne(x => x.NhanVien).WithMany(y => y.PhongBanNhanViens).HasForeignKey(z => z.MaNV);
        }
    }
}
