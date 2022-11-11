using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ITheLoaiService
    {
        string Add(TheLoaiView tlView);
        string Delete(TheLoaiView tlView);
        string Update(TheLoaiView tlView);
        List<TheLoaiView> GetAll();
    }
}
