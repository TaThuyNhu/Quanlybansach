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
//    public class CuaHangRepository : ICuaHangRepository
//    {
//        private FpolyDBContext _dBContext;
//        List<CuaHang> _CuaHangList;
//        public CuaHangRepository()
//        {
//            _dBContext = new FpolyDBContext();
//            _CuaHangList = new List<CuaHang>();
//        }

//        public bool AddCuaHang(CuaHang obj)
//        {
//            if (obj == null) return false;
//            _dBContext.CuaHangs.Add(obj);
//            _dBContext.SaveChanges();
//            return true;
//        }



//        public bool DeleteCuaHang(CuaHang obj)
//        {
//            if (obj == null) return false;
//            var temp = _dBContext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
//            _dBContext.CuaHangs.Remove(temp);
//            _dBContext.SaveChanges();
//            return true;
//        }
            

//        public List<CuaHang> GetAllCuaHang()
//        {
//            _CuaHangList = _dBContext.CuaHangs.ToList();
//            return _CuaHangList;
//        }

//        public CuaHang GetById(Guid id)
//        {
//            throw new NotImplementedException();
//        }


//        public bool UpdateCuaHang(CuaHang obj)
//        {
//            if (obj == null) return false;
//            var temp = _dBContext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
//            temp.Ma = obj.Ma;
//            temp.Ten = obj.Ten;
//            temp.DiaChi = obj.DiaChi;
//            temp.ThanhPho = obj.ThanhPho;
//            temp.QuocGia = obj.QuocGia;

//            _dBContext.CuaHangs.Update(temp);
//            _dBContext.SaveChanges();
//            return true;
//        }
//    }
//}
