using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICuaHangService
    {
        Guid GetIdCuaHangFromTen(string ten);
        string Add(CuaHangView cuaHangView);
        string Delete(CuaHangView cuaHangView);
        string Update(CuaHangView cuaHangView);
        List<CuaHangView> GetAll();

    }
}
