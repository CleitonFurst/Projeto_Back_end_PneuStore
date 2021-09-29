using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public interface IVendaService
    {
        List<Produto> All();
        bool Delete(int? id);
        bool Create(Produto p, string user);
        Produto Get(int? id);
        bool Update(Produto p, string user);
    }
}
