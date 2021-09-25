using API_Pneus.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pneus.Controllers
{
    //aguardando criação do ApiBaseController


    //public class ProdutosController : ApiBaseController
    //{
    //    IProdutosService _service;

    //    public ProdutosController(IProdutosService service)
    //    {
    //        _service = service;
    //    }

    //    [HttpGet]
    //    public IActionResult Index() =>
    //        ApiOk(_service.All());


    //    //[AuthorizeRoles(RoleType.Admin)]
    //    [Route("{id}")]
    //    [HttpGet]
    //    public IActionResult Index(int? id)
    //    {
    //        Produtos exists = _service.Get(id);
    //        return exists == null ?
    //            ApiNotFound("Não foi encontrado o produto solicitado.") :
    //            ApiOk(exists);
    //    }


    }
}
