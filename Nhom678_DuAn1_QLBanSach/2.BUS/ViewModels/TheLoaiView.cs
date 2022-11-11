using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class TheLoaiView
    {
        public string MaTheLoai { get; set; }
        public string MoTa { get; set; }
        public int? TrangThai { get; set; }
    }
}
