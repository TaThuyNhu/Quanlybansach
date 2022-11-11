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
    public class GiamGiaView
    {
        public string MaGg { get; set; }
        public string DoiTuongGg { get; set; }
        public DateTime ThoiHan { get; set; }
        public double PhanTram { get; set; }
        public int TrangThai { get; set; }
    }
}
