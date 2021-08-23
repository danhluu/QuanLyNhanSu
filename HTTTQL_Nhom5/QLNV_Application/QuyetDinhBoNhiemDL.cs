using Common.Data.Common;
using Common.Data.EF;
using Common.Data.Model;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace QLNV_Application
{
    public class QuyetDinhBoNhiemDL : BaseDL<QuyetDinhBoNhiem>, IQuyetDinhBoNhiemDL
    {
        public QuyetDinhBoNhiemDL(QLNVDbContext dl) : base(dl)
        {
        }

        public async Task<IEnumerable<QuyetDinhBoNhiemHienThi>> HienThiQDBN()
        {
            var query = from qdbn in _dl.QuyetDinhBoNhiems
                        join nv in _dl.NhanViens on qdbn.MaNV equals nv.MaNV
                        join ql in _dl.QuanLies on qdbn.MaQL equals ql.MaQL
                        join cv in _dl.ChucVus on qdbn.MaChucVu equals cv.MaChucVu
                        select new { nv,qdbn, ql, cv };
            var data = await query.Select(x => new QuyetDinhBoNhiemHienThi() { 
                    MaQDBN = x.qdbn.MaQDBN,
                    NgayBoNhiem = x.qdbn.NgayBoNhiem,
                    IsHide = x.qdbn.IsHide,
                    MaNV = x.nv.MaNV,
                    TenNhanVien = x.nv.username,
                    MaQL = x.ql.MaQL,
                    TenQuanLy = x.ql.HoTen,
                    MaChucVu = x.cv.MaChucVu,
                    TenChucVu = x.cv.TenChucVu
            
            }).Where(z=>z.IsHide==1).ToListAsync();

            return data;
        }
        public async Task<int> SetIsHide(int Ma)
        {
            var entity = await _dl.QuyetDinhBoNhiems.FindAsync(Ma);
            if (entity.IsHide == 1)
            {
                entity.IsHide = 0;
            }
            else
            {
                entity.IsHide = 1;
            }
            _dl.Update(entity);
            return await _dl.SaveChangesAsync();
        }
    }
}
