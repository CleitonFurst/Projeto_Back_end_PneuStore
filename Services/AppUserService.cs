using API_Pneus.Data;
using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Services
{
    public class AppUserService : IAppUserService
    {
        Context _context;
        public AppUserService(Context context)
        {
            this._context = context;
        }

        public bool create(Produtos produto)
        {
            throw new NotImplementedException();
        }

        public bool delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Produtos get(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Produtos> getAll()
        {
            throw new NotImplementedException();
        }

        public bool update(Produtos c)
        {
            throw new NotImplementedException();
        }
    }
}
