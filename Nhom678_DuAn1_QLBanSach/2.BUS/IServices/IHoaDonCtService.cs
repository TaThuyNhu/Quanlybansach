using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonCtService
    {
        string Add(HoaDonCtView hoaDonCtView);
        string Update(HoaDonCtView hoaDonCtView);
        string Delete(HoaDonCtView hoaDonCtView);
        List<HoaDonCtView> GetAll();
    }
}
