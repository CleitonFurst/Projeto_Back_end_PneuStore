using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Models
{
<<<<<<< HEAD:Models/Cliente.cs
    public class Cliente : IdentityUser    {

        public int ClienteID { get; set; }
        public virtual List<Venda> Vendas { get; set; }
=======
    public class AppUser : IdentityUser    {

        public int? carrinhoId { get; set; }
        public Carrinho carrinho { get; set; }
>>>>>>> 51d46da069e7855072cb1e9c8a39f4d6fb529ab7:Models/AppUser.cs
    }
}
