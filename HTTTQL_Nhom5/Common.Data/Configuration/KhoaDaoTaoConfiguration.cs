using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class KhoaDaoTaoConfiguration : IEntityTypeConfiguration<KhoaDaoTao>
    {
        public void Configure(EntityTypeBuilder<KhoaDaoTao> builder)
        {
            builder.ToTable("KhoaDaoTao");
            builder.HasKey(x => x.MaKhoaDaoTao);
            builder.Property(x => x.NgayBatDau).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(x => x.NhanVien).WithMany(y => y.KhoaDaoTaos).HasForeignKey(z => z.MaNV);
        }
    }
}
