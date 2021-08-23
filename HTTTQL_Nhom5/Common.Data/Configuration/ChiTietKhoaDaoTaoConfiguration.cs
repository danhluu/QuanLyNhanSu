using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class ChiTietKhoaDaoTaoConfiguration : IEntityTypeConfiguration<ChiTietKhoaDaoTao>
    {
        public void Configure(EntityTypeBuilder<ChiTietKhoaDaoTao> builder)
        {
            builder.ToTable("ChiTietKhoaDaoTao");
            builder.HasKey(x => x.MaHV);
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(x => x.KhoaDaoTao).WithMany(y => y.ChiTietKhoaDaoTaos).HasForeignKey(z => z.MaKhoaDaoTao);
        }
    }
}
