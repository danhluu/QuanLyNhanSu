using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class ThuongConfiguration : IEntityTypeConfiguration<Thuong>
    {
        public void Configure(EntityTypeBuilder<Thuong> builder)
        {
            builder.ToTable("Thuong");
            builder.HasKey(x => x.MaThuong);
            builder.Property(x => x.MucThuong).HasDefaultValue(0);
            builder.Property(x => x.NgayTao).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

        }
    }
}
