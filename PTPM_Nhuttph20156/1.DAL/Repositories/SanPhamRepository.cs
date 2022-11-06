//using _1.DAL.Context;
//using _1.DAL.DomainClass;
//using _1.DAL.IRepositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1.DAL.Repositories
//{
//    public class SanPhamRepository : ISanPhamRepository
//    {
//        private FpolyDBContext _dbContext;
//        List<SanPham> _lstSanPham;

//        public SanPhamRepository()
//        {
//            _dbContext = new FpolyDBContext();
//            _lstSanPham = new List<SanPham>();
//        }

//        public bool AddSanPham(SanPham sanPham)
//        {
//            if (sanPham == null) return false;
//            _dbContext.SanPhams.Add(sanPham);
//            _dbContext.SaveChanges();
//            return true;
//        }


//        public bool DeleteSanPham(SanPham sanPham)
//        {
//            if (sanPham == null) return false;
//            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == sanPham.Id);
//            _dbContext.SanPhams.Remove(tempobj);
//            _dbContext.SaveChanges();
//            return true;
//        }

//        public List<SanPham> GetAll()
//        {
//            _lstSanPham = _dbContext.SanPhams.ToList();
//            return _lstSanPham;
//        }

//        public SanPham GetById(Guid id)
//        {
//            throw new NotImplementedException();
//        }

//        public bool UpdateSanPham(SanPham sanPham)
//        {
//            if (sanPham == null) return false;
//            //obj.Id = Guid.NewGuid();// tu dong zen khoa chinh
//            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == sanPham.Id);
//            tempobj.Ma = sanPham.Ma;
//            tempobj.Ten = sanPham.Ten;            
//            _dbContext.SanPhams.Update(tempobj);
//            _dbContext.SaveChanges();
//            return true;
//        }
//    }
//}
