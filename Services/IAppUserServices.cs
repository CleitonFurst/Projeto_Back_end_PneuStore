using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public interface IAppUserServices
    {
        bool create(Produtos produto);
        bool delete(int? id);
        Produtos get(int? id);
        List<Produtos> getAll();
        bool update(Produtos c);
    }
}
