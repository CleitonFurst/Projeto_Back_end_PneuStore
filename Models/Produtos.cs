using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string NomeProd { get; set; }
        public string  Descricao { get; set; }
        public double Preco { get; set; }       
        public string Marca { get; set; }
        public string Img { get; set; }
        
    }
}
