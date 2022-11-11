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
    public class TheLoaiCtRepository : ITheLoaiCtRepository
    {
        private Nhom678 _dBContext;
        List<TheLoaiChiTiet> theLoaiChiTiets;
        public TheLoaiCtRepository()
        {
            _dBContext = new Nhom678();
            theLoaiChiTiets = new List<TheLoaiChiTiet>();
        }
        public bool AddTheLoaiCt(TheLoaiChiTiet tlct)
        {
            if (tlct == null) return false;
            _dBContext.TheLoaiChiTiets.Add(tlct);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteTheLoaiCt(TheLoaiChiTiet tlct)
        {
            if (tlct == null) return false;
            var temp = _dBContext.TheLoaiChiTiets.FirstOrDefault(c => c.MaTheLoaiChiTiet == tlct.MaTheLoaiChiTiet);
            _dBContext.TheLoaiChiTiets.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<TheLoaiChiTiet> GetAllTheLoaiCt()
        {
            theLoaiChiTiets = _dBContext.TheLoaiChiTiets.ToList();
            return theLoaiChiTiets;
        }

        public TheLoaiChiTiet GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTheLoaiCt(TheLoaiChiTiet tlct)
        {
            if (tlct == null) return false;
            var temp = _dBContext.TheLoaiChiTiets.FirstOrDefault(c => c.MaTheLoaiChiTiet == tlct.MaTheLoaiChiTiet);
            //temp.Ma = obj.Ma;
            temp.TenTheLoai = tlct.TenTheLoai;
            temp.TrangThai = tlct.TrangThai;
            _dBContext.TheLoaiChiTiets.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
