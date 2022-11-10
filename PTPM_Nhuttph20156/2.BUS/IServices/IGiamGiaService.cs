using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IGiamGiaService
    {
        string Add(GiamGiaView giamGiaView);
        string Update(GiamGiaView giamGiaView);
        string Delete(GiamGiaView giamGiaView);
        List<GiamGiaView> GetAll();
    }
}
