using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonService
    {
        string Add(HoaDonView hoaDonView);
        string Delete(HoaDonView hoaDonView);
        string Update(HoaDonView hoaDonView);
        List<HoaDonView> GetAll();
    }
}
