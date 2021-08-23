using Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Configuration
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.MaNV);
            builder.Property(x => x.HoTen).IsRequired();
            builder.Property(x => x.username).IsRequired();
            builder.Property(x => x.password).IsRequired();

            builder.HasOne(x => x.PhongBan).WithMany(y => y.NhanViens).HasForeignKey(z => z.MaPhongBan);
        }
    }
}
