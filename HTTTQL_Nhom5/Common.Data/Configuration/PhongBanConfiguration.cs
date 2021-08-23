using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class PhongBanConfiguration : IEntityTypeConfiguration<PhongBan>
    {
        public void Configure(EntityTypeBuilder<PhongBan> builder)
        {
            builder.ToTable("PhongBan");
            builder.HasKey(x => x.MaPhongBan);
            builder.Property(x => x.TenPhongBan).IsRequired();
            builder.Property(x => x.NgayTao).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(x => x.CongTy).WithMany(y => y.PhongBans).HasForeignKey(z => z.MaCongTy);
        }
    }
}
