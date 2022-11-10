using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private Nhom678 _dBContext;
        List<HoaDon> _hoaDon;
        public HoaDonRepository()
        {
            _dBContext = new Nhom678();
            _hoaDon = new List<HoaDon>();
        }
        public bool AddHoaDon(HoaDon hd)
        {
            if (hd == null) return false;
            _dBContext.HoaDons.Add(hd);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteHoaDon(HoaDon hd)
        {
            if (hd == null) return false;
            var temp = _dBContext.HoaDons.FirstOrDefault(c => c.MaHoaDon == hd.MaHoaDon);
            _dBContext.HoaDons.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAllHoaDon()
        {
            _hoaDon = _dBContext.HoaDons.ToList();
            return _hoaDon;
        }
    

        public HoaDon GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateHoaDon(HoaDon hd)
        {
            if (hd == null) return false;
            var temp = _dBContext.HoaDons.FirstOrDefault(c => c.MaHoaDon == hd.MaHoaDon);
            //temp.Ma = obj.Ma;
            temp.MaKhachHang = hd.MaKhachHang;
            temp.MaNhanVien = hd.MaNhanVien;
            temp.NgayShip = hd.NgayShip;
            temp.NgayNhan = hd.NgayNhan;
            temp.TrangThai = hd.TrangThai;
            _dBContext.HoaDons.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
