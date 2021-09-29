using API_Pneus.Data;
using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public class VendaService : IVendaService
    {
        Context _context;

        public VendaService(Context context)
        {
            _context = context;
        }

        public List<Produto> All()
        {
            return _context.Produtos.ToList();
        }

        public bool Create(Produto p, string user)
        {
            try
            {
                //p.createBy = user;
                _context.Add(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Produto Get(int? id)
        {
            return _context.Produtos.FirstOrDefault(p => p.ProdutoID == id);
        }

        public bool Update(Produto prod, string user)
        {
            try
            {
                if (!_context.Produtos.Any(p => p.ProdutoID == prod.ProdutoID)) throw new Exception("Produto não existe!");

                //prod.updatedBy = user;
                //prod.createBy = _context.Produtos.AsNoTracking().FirstOrDefault(p => p.Id == prod.Id).createBy;
                _context.Update(prod);
                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            try
            {
                _context.Remove(this.Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
