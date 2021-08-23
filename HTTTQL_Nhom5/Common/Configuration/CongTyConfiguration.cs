using Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Configuration
{
    public class CongTyConfiguration : IEntityTypeConfiguration<CongTy>
    {
        public void Configure(EntityTypeBuilder<CongTy> builder)
        {
            builder.ToTable("CongTy");
            builder.HasKey(x => x.MaCongTy);
            builder.Property(x => x.TenCongTy).IsRequired();

        }
    }
}
