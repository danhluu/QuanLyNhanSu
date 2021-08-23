using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class ChucVuNhanVienConfiguration : IEntityTypeConfiguration<ChucVuNhanVien>
    {
        public void Configure(EntityTypeBuilder<ChucVuNhanVien> builder)
        {
            builder.ToTable("ChucVuNhanVien");
            builder.HasKey(x => x.MaCVNV);
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(x => x.ChucVu).WithMany(y => y.ChucVuNhanVien).HasForeignKey(fk => fk.MaChucVu);
            builder.HasOne(x => x.NhanVien).WithOne(y => y.ChucVuNhanVien).HasForeignKey<ChucVuNhanVien>(fk => fk.MaNV);

        }
    }
}
