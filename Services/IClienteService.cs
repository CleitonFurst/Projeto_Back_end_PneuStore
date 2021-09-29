using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public interface IClienteService
    {
        bool create(Produto produto);
        bool delete(int? id);
        Produto get(int? id);
        List<Produto> getAll();
        bool update(Produto c);
    }
}
