using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ITheLoaiRepository
    {
        List<TheLoai> GetAllTheLoai();
        TheLoai GetById(Guid Ma); // phuong thuc tim san pham theo ID

        bool AddTheLoai(TheLoai tl);
        bool UpdateTheLoai(TheLoai tl);
        bool DeleteTheLoai(TheLoai tl);
    }
}
