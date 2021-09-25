using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    interface IProdutosService
    {
        Produtos Get(int? id);
    }
}
