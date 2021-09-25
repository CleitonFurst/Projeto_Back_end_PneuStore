using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public interface ICarrinhoService
    {
        List<Produtos> All();
        bool Delete(int? id);
        bool Create(Produtos p, string user);
        Produtos Get(int? id);
        bool Update(Produtos p, string user);
    }
}
