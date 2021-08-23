using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class HopDongConfiguration : IEntityTypeConfiguration<HopDong>
    {
        public void Configure(EntityTypeBuilder<HopDong> builder)
        {
            builder.ToTable("HopDong");
            builder.HasKey(x => x.MaHopDong);
            builder.Property(x => x.NgayTao).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

        }
    }
}
