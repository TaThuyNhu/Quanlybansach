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
    public class TheLoaiRepository : ITheLoaiRepository
    {
        private Nhom678 _dBContext;
        List<TheLoai> theLoai;
        public TheLoaiRepository()
        {
            _dBContext = new Nhom678();
            theLoai = new List<TheLoai>();
        }
        public bool AddTheLoai(TheLoai tl)
        {
            if (tl == null) return false;
            _dBContext.TheLoais.Add(tl);
            _dBContext.SaveChanges();
            return true;
        }

        public bool DeleteTheLoai(TheLoai tl)
        {
            if (tl == null) return false;
            var temp = _dBContext.TheLoais.FirstOrDefault(c => c.MaTheLoai == tl.MaTheLoai);
            _dBContext.TheLoais.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<TheLoai> GetAllTheLoai()
        {
            theLoai = _dBContext.TheLoais.ToList();
            return theLoai;
        }

        public TheLoai GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTheLoai(TheLoai tl)
        {
            if (tl == null) return false;
            var temp = _dBContext.TheLoais.FirstOrDefault(c => c.MaTheLoai == tl.MaTheLoai);
            //temp.Ma = obj.Ma;
            temp.MoTa = tl.MoTa;
            temp.TrangThai = tl.TrangThai;
            _dBContext.TheLoais.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
