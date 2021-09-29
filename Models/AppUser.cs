using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Models
{
    public class AppUser : IdentityUser    {

        public int? carrinhoId { get; set; }
        public Carrinho carrinho { get; set; }
    }
}
