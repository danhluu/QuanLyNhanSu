using Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Configuration
{
    public class ChucVuNhanVienConfiguration : IEntityTypeConfiguration<ChucVuNhanVien>
    {
        public void Configure(EntityTypeBuilder<ChucVuNhanVien> builder)
        {
            builder.ToTable("ChucVuNhanVien");
            builder.HasKey(x => x.MaCVNV);

            builder.HasOne(x => x.ChucVu).WithMany(y => y.ChucVuNhanVien).HasForeignKey(fk => fk.MaChucVu);
            builder.HasOne(x => x.NhanVien).WithOne(y => y.ChucVuNhanVien).HasForeignKey<ChucVuNhanVien>(fk => fk.MaNV);

        }
    }
}
