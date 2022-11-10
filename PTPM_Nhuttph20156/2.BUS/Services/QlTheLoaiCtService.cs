using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace _2.BUS.Services
{
    public class QlTheLoaiCtService : ITheLoaiCtService
    {
        private ITheLoaiCtRepository _iTheLoaiCtRepository;

        public QlTheLoaiCtService()
        {
            _iTheLoaiCtRepository = new TheLoaiCtRepository();
        }

        public string Add(TheLoaiCtView theLoaiCtView)
        {
            if (theLoaiCtView == null) return "Them khong thanh cong";
            var obj = new TheLoaiChiTiet()
            {
                MaTheLoaiChiTiet = theLoaiCtView.MaTheLoaiChiTiet,
                TenTheLoai = theLoaiCtView.TenTheLoai,
            };
            if (_iTheLoaiCtRepository.AddTheLoaiCt(obj))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(TheLoaiCtView theLoaiCtView)
        {
            if (theLoaiCtView == null) return "Xoa khong thanh cong";
            var obj = new TheLoaiChiTiet()
            {
                MaTheLoaiChiTiet = theLoaiCtView.MaTheLoaiChiTiet,
                TenTheLoai = theLoaiCtView.TenTheLoai,
            };
            if (_iTheLoaiCtRepository.DeleteTheLoaiCt(obj))
                return "Xoa thanh cong";
            return "Xoa khong thanh cong";
        }

        public List<TheLoaiCtView> GetAll()
        {
            List<TheLoaiCtView> list = new List<TheLoaiCtView>();
            list = (from a in _iTheLoaiCtRepository.GetAllTheLoaiCt()
                    select new TheLoaiCtView
                    {
                        MaTheLoaiChiTiet = a.MaTheLoaiChiTiet,
                        TenTheLoai = a.TenTheLoai,
                    }).ToList();
            return list;
        }

        public string Update(TheLoaiCtView theLoaiCtView)
        {
            if (theLoaiCtView == null) return "Sua khong thanh cong";
            var obj = new TheLoaiChiTiet()
            {
                MaTheLoaiChiTiet = theLoaiCtView.MaTheLoaiChiTiet,
                TenTheLoai = theLoaiCtView.TenTheLoai,
            };
            if (_iTheLoaiCtRepository.UpdateTheLoaiCt(obj))
                return "Sua thanh cong";
            return "Sua khong thanh cong";
        }
    }
}