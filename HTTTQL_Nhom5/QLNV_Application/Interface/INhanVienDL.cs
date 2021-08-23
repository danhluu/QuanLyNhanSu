using Common.Data.Common;
using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface INhanVienDL : IBaseDL<NhanVien>
    {
        Task<IEnumerable<NhanVienHienThi>> DanhSachNhanVien();
        Task<int> ChangeStatus(int MaNV);
        Task<IEnumerable<NhanVien>> GetAllData();
        Task<int> SetIsHide(int MaNV);

        Task<IEnumerable<NhanVien>> NhanVienChuaCoHopDong();

        Task<NhanVien> getNhanVietByUserName(String username);
        Task<int> DoiMatKhau(Login nv);

    }
}
