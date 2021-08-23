﻿using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class ChiTietHopDongConfiguration : IEntityTypeConfiguration<ChiTietHopDong>
    {
        public void Configure(EntityTypeBuilder<ChiTietHopDong> builder)
        {
            builder.ToTable("ChiTietHopDong");

            builder.HasKey(x => x.MaCTHD);
            builder.Property(x => x.LoaiHopDong).IsRequired();
            builder.Property(x=>x.NgayKy).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.NgayTao).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(ql => ql.QuanLy).WithMany(cthd => cthd.ChiTietHopDongs).HasForeignKey(fk => fk.MaQL);
            builder.HasOne(nv => nv.NhanVien).WithOne(cthd => cthd.ChiTietHopDong).HasForeignKey<ChiTietHopDong>(fk => fk.MaNV);
            builder.HasOne(hd => hd.HopDong).WithMany(cthd => cthd.ChiTietHopDongs).HasForeignKey(fk => fk.MaHopDong);



        }
    }
}
