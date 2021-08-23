using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Configuration
{
    public class QuyetDinhBoNhiemConfiguration : IEntityTypeConfiguration<QuyetDinhBoNhiem>
    {
        public void Configure(EntityTypeBuilder<QuyetDinhBoNhiem> builder)
        {
            builder.ToTable("QuyetDinhBoNhiem");
            builder.HasKey(x => x.MaQDBN);
            builder.Property(x => x.NgayBoNhiem).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.IsHide).HasDefaultValueSql("1");

            builder.HasOne(x => x.NhanVien).WithMany(y => y.QuyetDinhBoNhiems).HasForeignKey(z => z.MaNV);
            builder.HasOne(x => x.QuanLy).WithMany(y => y.QuyetDinhBoNhiems).HasForeignKey(z => z.MaQL);
            builder.HasOne(x => x.ChucVu).WithMany(y => y.QuyetDinhBoNhiems).HasForeignKey(z => z.MaChucVu);
        }
    }
}
