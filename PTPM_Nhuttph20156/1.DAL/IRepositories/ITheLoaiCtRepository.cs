using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ITheLoaiCtRepository
    {
        List<TheLoaiChiTiet> GetAllTheLoaiCt();
        TheLoaiChiTiet GetById(Guid Ma); // phuong thuc tim san pham theo ID

        bool AddTheLoaiCt(TheLoaiChiTiet tlct);
        bool UpdateTheLoaiCt(TheLoaiChiTiet tlct);
        bool DeleteTheLoaiCt(TheLoaiChiTiet tlct);
    }
}
