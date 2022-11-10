using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChucVuService
    {
        string Add(ChucVuView cvView);
        string Delete(ChucVuView cvView);
        string Update(ChucVuView cvView);
        List<ChucVuView> GetAll();
    }
}
