using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonCtView
    {
        public string MaHoaDonChiTiet { get; set; }
        public string MaHoaDon { get; set; }
        public string MaSach { get; set; }
        public string MaGiamGia { get; set; }
        public int? GiaGoc { get; set; }
        public int? GiaBan { get; set; }
        public int? SoLuong { get; set; }
        public int TrangThai { get; set; }

    }
}
