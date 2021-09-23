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
        public int carrinhoId { get; set; }
        public Carrinho carrinho { get; set; }
<<<<<<< HEAD
        
=======
        //teste
        //opa
<<<<<<< Updated upstream
=======
>>>>>>> b9251a7351d330710aabd39b79f5e54e950346aa
>>>>>>> Stashed changes

    }
}
