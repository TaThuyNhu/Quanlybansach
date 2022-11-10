using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISachService
    {
        string Add(SachView sachView);
        string Update(SachView sachView);
        string Delete(SachView sachView);
        List<SachView> GetAll();
    }
}
