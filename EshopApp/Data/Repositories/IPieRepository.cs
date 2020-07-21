using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EshopApp.Data.Entities;

namespace EshopApp.Data.Repositories
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}
