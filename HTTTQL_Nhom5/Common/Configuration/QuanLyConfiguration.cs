using Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Configuration
{
    public class QuanLyConfiguration : IEntityTypeConfiguration<QuanLy>
    {
        public void Configure(EntityTypeBuilder<QuanLy> builder)
        {
            builder.ToTable("QuanLy");
            builder.HasKey(x => x.MaQL);
            builder.Property(x => x.username).IsRequired();
            builder.Property(x => x.password).IsRequired();
            builder.Property(x => x.HoTen).IsRequired();

        }
    }
}
