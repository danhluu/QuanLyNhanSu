using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class DonXinConfiguration : IEntityTypeConfiguration<DonXin>
    {
        public void Configure(EntityTypeBuilder<DonXin> builder)
        {
            builder.ToTable("DonXin");
            builder.HasKey(x => x.MaDon);
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");
            builder.Property(x => x.Status).HasDefaultValueSql("0");
            builder.Property(x => x.NgayViet).HasDefaultValueSql("GetDate()");

            builder.HasOne(x => x.NhanVien).WithMany(y => y.DonXins).HasForeignKey(z => z.MaNV);

        }
    }
}
