using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Models
{
    public class Carrinho 
    {
        public int Id { get; set; }
        public int Quant { get; set; }
        public AppUser appuser { get; set; }
        public List<Produtos> Produtos { get; set; }

        //public int? produtosId { get; set; }

        public Produtos produtos { get; set; }

    }
}
