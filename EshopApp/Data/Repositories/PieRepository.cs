using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EshopApp.Data.Entities;

namespace EshopApp.Data.Repositories
{
    public class PieRepository: IPieRepository
    {
        private readonly EshopContext _appDbContext;

        public PieRepository(EshopContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
