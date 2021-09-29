using API_Pneus.Models;
using API_Pneus.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace API_Pneus.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ApiBaseController
    {
        IVendaService _service;

        public VendaController(IVendaService service)
        {
            _service = service;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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


        //[AuthorizeRoles(RoleType.Admin)]
        /// <summary>
        
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] Produto prod) =>
            _service.Create(prod, User.Identity.Name) ?
                ApiOk("Produto criado com sucesso!") :
                ApiNotFound("Erro ao criar produto!");

        //[AuthorizeRoles(RoleType.Admin)]
        [HttpPut]
        public IActionResult Update([FromBody] Produto prod) =>
            _service.Update(prod, User.Identity.Name) ?
                ApiOk("Produto atualizado com sucesso!") :
                ApiNotFound("Erro ao atualizar produto!");

        //[AuthorizeRoles(RoleType.Admin)]
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
                ApiOk("Produto deletado com sucesso!") :
                ApiNotFound("Erro ao deletar produto!");

    }
}
