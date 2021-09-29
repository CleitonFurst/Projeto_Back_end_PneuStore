using API_Pneus.Models;
using API_Pneus.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ApiBaseController
    {
        IProdutoService _service;


        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index() =>
            ApiOk(_service.All());


        //[AuthorizeRoles(RoleType.Admin)]
        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            Produto exists = _service.Get(id);
            return exists == null ?
                ApiNotFound("Não foi encontrado o produto solicitado.") :
                ApiOk(exists);
        }


    }
}
