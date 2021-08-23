using Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Configuration
{
    public class BangCapConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<BangCap>
    {
        public void Configure(EntityTypeBuilder<BangCap> builder)
        {
            builder.ToTable("BangCap");

            builder.HasKey(x => x.MaBangCap);
            builder.Property(x => x.TenChuyenMon).IsRequired();

            builder.HasOne(tv => tv.NhanVien).WithMany(bc => bc.BangCaps).HasForeignKey(fk=>fk.MaNV);
            
        }
    }
}
