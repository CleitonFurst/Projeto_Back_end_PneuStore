using API_Pneus.Data;
using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public class ProdutoService : IProdutoService
    {
        Context _context;

        public ProdutoService(Context context)
        {
            _context = context;
        }

        public List<Produto> All()
        {
            return _context.Produtos.ToList();
        }

        public Produto Get(int? id)
        {
            return _context.Produtos.FirstOrDefault(p => p.ProdutoID == id);
        }
    }
}
