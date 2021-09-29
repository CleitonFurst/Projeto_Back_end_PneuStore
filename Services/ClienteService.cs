

using API_Pneus.Data;
using API_Pneus.Models;
using System.Collections.Generic;

namespace API_Pneus.Services
{
    public class ClienteService : IClienteService
    {
        Context _context;
        public ClienteService(Context context)
        {
            this._context = context;
        }

        public bool create(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public bool delete(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Produto get(int? id)
        {
            throw new System.NotImplementedException();
        }

        public List<Produto> getAll()
        {
            throw new System.NotImplementedException();
        }

        public bool update(Produto c)
        {
            throw new System.NotImplementedException();
        }
    }
}
