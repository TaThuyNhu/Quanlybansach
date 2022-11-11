using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace _2.BUS.Services
{
    public class QlGiamGiaService : IGiamGiaService
    {
        private IGiamGiaRepository _iGiamGiaRepository;

        public QlGiamGiaService()
        {
            _iGiamGiaRepository = new GiamGiaRepository();
        }

        public string Add(GiamGiaView giamGiaView)
        {
            if (giamGiaView == null) return "Them khong thanh cong";
            var obj = new GiamGium()
            {
                MaGg = giamGiaView.MaGg,
                DoiTuongGg = giamGiaView.DoiTuongGg,
                ThoiHan = giamGiaView.ThoiHan,
                PhanTram = giamGiaView.PhanTram,
            };
            if (_iGiamGiaRepository.AddGiamGia(obj))
                return "Them thanh cong";
            return "Them khong thanh cong";
        }

        public string Delete(GiamGiaView giamGiaView)
        {
            if (giamGiaView == null) return "Xoa khong thanh cong";
            var obj = new GiamGium()
            {
                MaGg = giamGiaView.MaGg,
                DoiTuongGg = giamGiaView.DoiTuongGg,
                ThoiHan = giamGiaView.ThoiHan,
                PhanTram = giamGiaView.PhanTram,
            };
            if (_iGiamGiaRepository.DeleteGiamGia(obj))
                return "Xoa thanh cong";
            return "Xoa khong thanh cong";
        }

        public List<GiamGiaView> GetAll()
        {
            List<GiamGiaView> list = new List<GiamGiaView>();
            list = (from a in _iGiamGiaRepository.GetAllGiamGia()
                    select new GiamGiaView
                    {
                        MaGg = a.MaGg,
                        DoiTuongGg = a.DoiTuongGg,
                        ThoiHan = a.ThoiHan,
                        PhanTram = a.PhanTram,
                    }).ToList();
            return list;
        }

        public string Update(GiamGiaView giamGiaView)
        {
            if (giamGiaView == null) return "Sua khong thanh cong";
            var obj = new GiamGium()
            {
                MaGg = giamGiaView.MaGg,
                DoiTuongGg = giamGiaView.DoiTuongGg,
                ThoiHan = giamGiaView.ThoiHan,
                PhanTram = giamGiaView.PhanTram,
            };
            if (_iGiamGiaRepository.UpdateGiamGia(obj))
                return "Sua thanh cong";
            return "Sua khong thanh cong";
        }
    }
}