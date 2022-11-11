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
    public class HoaDonCtRepository : IHoaDonCtRepository
    {
        private Nhom678 _dBContext;
        List<HoaDonChiTiet> hDCT;
        public HoaDonCtRepository()
        {
            _dBContext = new Nhom678();
            hDCT = new List<HoaDonChiTiet>();
        }
        public bool AddHoaDonCt(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            _dBContext.HoaDonChiTiets.Add(hdct);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteHoaDonCt(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            var temp = _dBContext.HoaDonChiTiets.FirstOrDefault(c => c.MaHoaDonChiTiet == hdct.MaHoaDonChiTiet);
            _dBContext.HoaDonChiTiets.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAllHoaDonCt()
        {
            hDCT = _dBContext.HoaDonChiTiets.ToList();
            return hDCT;
        }

        public HoaDonChiTiet GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateHoaDonCt(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            var temp = _dBContext.HoaDonChiTiets.FirstOrDefault(c => c.MaHoaDonChiTiet == hdct.MaHoaDonChiTiet);
            //temp.Ma = obj.Ma;
            temp.MaHoaDon = hdct.MaHoaDon;
            temp.MaSach = hdct.MaSach;
            temp.MaGiamGia = hdct.MaGiamGia;
            temp.GiaGoc = hdct.GiaGoc;
            temp.GiaBan = hdct.GiaBan;
            temp.SoLuong = hdct.SoLuong;
            temp.TrangThai = hdct.TrangThai;
            _dBContext.HoaDonChiTiets.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
