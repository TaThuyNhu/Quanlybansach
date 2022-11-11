using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class KhachHangView
    {
        //public Guid Id { get; set; }
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public int SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public int TrangThai { get; set; }


    }
}

