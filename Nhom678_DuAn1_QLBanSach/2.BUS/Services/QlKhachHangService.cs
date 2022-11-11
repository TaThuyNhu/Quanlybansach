using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QlKhachHangService : IKhachHangService
    {
        private IKhachHangRepository _iKhachHangRepository;
        public QlKhachHangService()
        {
            _iKhachHangRepository = new KhachHangRepository();
        }
        public string Add(KhachHangView kh)
        {
            if (kh == null) return "Them khong thanh cong";
            var obj = new KhachHang()
            {
                MaKhachHang = kh.MaKhachHang,
                HoTen = kh.HoTen,
                GioiTinh = kh.GioiTinh,
                Tuoi = kh.Tuoi,
                SoDienThoai = kh.SoDienThoai,
                Email = kh.Email,
                DiaChi = kh.DiaChi,
                TrangThai = kh.TrangThai,
            };
            if (_iKhachHangRepository.AddKhachHang(obj))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(KhachHangView kh)
        {
            if (kh == null) return "Xoa khong thanh cong";
            var obj = new KhachHang()
            {
                MaKhachHang = kh.MaKhachHang,
                HoTen = kh.HoTen,
                GioiTinh = kh.GioiTinh,
                Tuoi = kh.Tuoi,
                SoDienThoai = kh.SoDienThoai,
                Email = kh.Email,
                DiaChi = kh.DiaChi,
                TrangThai = kh.TrangThai,
            };
            if (_iKhachHangRepository.DeleteKhachHang(obj))
                return "Xoa thanh cong";
            return "Xoa khong thanh cong";
        }

        public List<KhachHangView> GetAll()
        {
            List<KhachHangView> list = new List<KhachHangView>();
            list = (from a in _iKhachHangRepository.GetAllKhachHang()
                    select new KhachHangView
                    {
                        MaKhachHang = a.MaKhachHang,
                        HoTen = a.HoTen,
                        GioiTinh = a.GioiTinh,
                        Tuoi = a.Tuoi,
                        SoDienThoai = a.SoDienThoai,
                        Email = a.Email,
                        DiaChi = a.DiaChi,
                        TrangThai = a.TrangThai,
                    }).ToList();
            return list;
        }

        public string Update(KhachHangView kh)
        {
            if (kh == null) return "Sua khong thanh cong";
            var obj = new KhachHang()
            {
                MaKhachHang = kh.MaKhachHang,
                HoTen = kh.HoTen,
                GioiTinh = kh.GioiTinh,
                Tuoi = kh.Tuoi,
                SoDienThoai = kh.SoDienThoai,
                Email = kh.Email,
                DiaChi = kh.DiaChi,
                TrangThai = kh.TrangThai,
            };
            if (_iKhachHangRepository.UpdateKhachHang(obj))
                return "Sua thanh cong";
            return "Sua khong thanh cong";
        }
    }
}
