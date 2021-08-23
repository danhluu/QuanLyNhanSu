using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class PhuCapConfiguration : IEntityTypeConfiguration<PhuCap>
    {
        public void Configure(EntityTypeBuilder<PhuCap> builder)
        {
            builder.ToTable("PhuCap");
            builder.HasKey(x => x.MaPhuCap);
            builder.Property(x => x.MucPhuCap).HasDefaultValue(0);
            builder.Property(x => x.NgayTao).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");
        }
    }
}
