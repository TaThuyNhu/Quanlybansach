using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class GiamGiaRepository : IGiamGiaRepository
    {
        private Nhom678 _dBContext;
        List<GiamGium> giamGia;
        public GiamGiaRepository()
        {
            _dBContext = new Nhom678();
            giamGia = new List<GiamGium>();
        }
        public bool AddGiamGia(GiamGium gg)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGiamGia(GiamGium gg)
        {
            throw new NotImplementedException();
        }

        public List<GiamGium> GetAllGiamGia()
        {
            throw new NotImplementedException();
        }

        public GiamGium GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateGiamGia(GiamGium gg)
        {
            throw new NotImplementedException();
        }
    }
}
