using API_Pneus.Data;
using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public class ProdutosService : IProdutosService
    {
        Context _context;

        public ProdutosService(Context context)
        {
            _context = context;
        }

        public List<Produtos> All()
        {
            return _context.Produtos.ToList();
        }

        public Produtos Get(int? id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }
    }
}
