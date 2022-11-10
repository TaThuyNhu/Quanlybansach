using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        List<HoaDon> GetAllHoaDon();
        HoaDon GetById(Guid Ma); // phuong thuc tim san pham theo ID

        bool AddHoaDon(HoaDon hd);
        bool UpdateHoaDon(HoaDon hd);
        bool DeleteHoaDon(HoaDon hd);
    }
}
