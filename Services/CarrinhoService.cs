﻿using API_Pneus.Data;
using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public class CarrinhoService : ICarrinhoService
    {
        Context _context;

        public CarrinhoService(Context context)
        {
            _context = context;
        }

        public List<Produtos> All()
        {
            return _context.Produtos.ToList();
        }

        public bool Create(Produtos p, string user)
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

        public Produtos Get(int? id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Produtos prod, string user)
        {
            try
            {
                if (!_context.Produtos.Any(p => p.Id == prod.Id)) throw new Exception("Produto não existe!");

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
