using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonCtRepository
    {
        List<HoaDonChiTiet> GetAllHoaDonCt();
        HoaDonChiTiet GetById(Guid Ma); // phuong thuc tim san pham theo ID

        bool AddHoaDonCt(HoaDonChiTiet hdct);
        bool UpdateHoaDonCt(HoaDonChiTiet hdct);
        bool DeleteHoaDonCt(HoaDonChiTiet hdct);
    }
}
