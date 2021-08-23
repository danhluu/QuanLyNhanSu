using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class BangCapConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<BangCap>
    {
        public void Configure(EntityTypeBuilder<BangCap> builder)
        {
            builder.ToTable("BangCap");

            builder.HasKey(x => x.MaBangCap);
            builder.Property(x => x.TenChuyenMon).IsRequired();
            builder.Property(x => x.NgayTao).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(tv => tv.HoSoNhanVien).WithMany(bc => bc.BangCaps).HasForeignKey(fk=>fk.MaHSNV);
            
        }
    }
}
