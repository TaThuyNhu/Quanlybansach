using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ITheLoaiCtService
    {
        string Add(TheLoaiCtView theLoaiCtView);
        string Delete(TheLoaiCtView theLoaiCtView);
        string Update(TheLoaiCtView theLoaiCtView);
        List<TheLoaiCtView> GetAll();
    }
}
