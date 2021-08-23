using Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Configuration
{
    public class BacLuongConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<BacLuong>
    {
        public void Configure(EntityTypeBuilder<BacLuong> builder)
        {
            builder.ToTable("BacLuong");
            builder.HasKey(x => x.MaBacLuong);
            builder.Property(x => x.LoaiLuong).IsRequired();
            builder.Property(x => x.MucLuong).IsRequired();


        }
    }
}
