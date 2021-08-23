using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class HoSoNhanVienConfiguration : IEntityTypeConfiguration<HoSoNhanVien>
    {
        public void Configure(EntityTypeBuilder<HoSoNhanVien> builder)
        {
            builder.ToTable("HoSoNhanVien");
            builder.HasKey(x => x.MaHSNV);
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

        }
    }
}
