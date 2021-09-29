using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public interface IProdutoService
    {
        List<Produto> All();
        Produto Get(int? id);
    }
}
