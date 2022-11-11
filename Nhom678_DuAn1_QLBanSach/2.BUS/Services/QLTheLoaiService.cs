using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace _2.BUS.Services
{
    public class QLTheLoaiService : ITheLoaiService
    {
        private ITheLoaiRepository _iTtheLoaiRepository;

        public QLTheLoaiService()
        {
            _iTtheLoaiRepository = new TheLoaiRepository();
        }

        public string Add(TheLoaiView tlView)
        {
            if (tlView == null) return "Them khong thanh cong";
            var obj = new TheLoai()
            {
                MaTheLoai = tlView.MaTheLoai,
                MoTa = tlView.MoTa,
            };
            if (_iTtheLoaiRepository.AddTheLoai(obj))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(TheLoaiView tlView)
        {
            if (tlView == null) return "Xoa khong thanh cong";
            var obj = new TheLoai()
            {
                MaTheLoai = tlView.MaTheLoai,
                MoTa = tlView.MoTa,
            };
            if (_iTtheLoaiRepository.DeleteTheLoai(obj))
                return "Xoa thanh cong";
            return "Xoa khong thanh cong";
        }

        public List<TheLoaiView> GetAll()
        {
            List<TheLoaiView> list = new List<TheLoaiView>();
            list = (from a in _iTtheLoaiRepository.GetAllTheLoai()
                    select new TheLoaiView
                    {
                        MaTheLoai = a.MaTheLoai,
                        MoTa = a.MoTa,
                    }).ToList();
            return list;
        }

        public string Update(TheLoaiView tlView)
        {
            if (tlView == null) return "Sua khong thanh cong";
            var obj = new TheLoai()
            {
                MaTheLoai = tlView.MaTheLoai,
                MoTa = tlView.MoTa,
            };
            if (_iTtheLoaiRepository.UpdateTheLoai(obj))
                return "Sua thanh cong";
            return "Sua khong thanh cong";
        }
    }
}