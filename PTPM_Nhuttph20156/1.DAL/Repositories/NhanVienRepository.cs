//using _1.DAL.Context;
//using _1.DAL.DomainClass;
//using _1.DAL.IRepositories;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1.DAL.Repositories
//{
//    public class NhanVienRepository : INhanVienRepository
//    {
//        private FpolyDBContext _dBContext;
//        List<NhanVien> _NhanVienList;
//        public NhanVienRepository()
//        {
//            _dBContext = new FpolyDBContext();
//            _NhanVienList = new List<NhanVien>();
//        }

//        public bool AddNhanVien(NhanVien nv)
//        {
//            if (nv == null) return false;
//            _dBContext.Add(nv);
//            _dBContext.SaveChanges();
//            return true;
//        }


//        public bool DeleteNhanVien(NhanVien nv)
//        {
//            if (nv == null) return false;
//            var tempobj = _dBContext.NhanViens.FirstOrDefault(c => c.Id == nv.Id);
//            _dBContext.Remove(tempobj);
//            _dBContext.SaveChanges();
//            return true;
//        }

//        public List<NhanVien> GetAll()
//        {
//            _NhanVienList = _dBContext.NhanViens.ToList();
//            return _NhanVienList;
//        }

//        public NhanVien GetById(Guid id)
//        {
//            throw new NotImplementedException();
//        }
//        public bool UpdateNhanVien(NhanVien nv)
//        {
//            if (nv == null) return false;
//            var obj = _dBContext.NhanViens.FirstOrDefault(c => c.Id == nv.Id);
//            obj.DiaChi = nv.DiaChi;
//            obj.GioiTinh = nv.GioiTinh;
//            obj.Ho = nv.Ho;
//            obj.IdCh = nv.IdCh;
//            obj.IdCv = nv.IdCv;
//            obj.IdGuiBc = nv.IdGuiBc;
//            obj.Ma = nv.Ma;
//            obj.MatKhau = nv.MatKhau;
//            obj.NgaySinh = nv.NgaySinh;
//            obj.Sdt = nv.Sdt;
//            obj.Ten = nv.Ten;
//            obj.TenDem = nv.TenDem;
//            obj.TrangThai = nv.TrangThai;

//            _dBContext.Update(obj);
//            _dBContext.SaveChanges();
//            return true;
//        }
//    }
//}
