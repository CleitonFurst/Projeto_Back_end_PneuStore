﻿using API_Pneus.Models;
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
    public class CarrinhoController : ApiBaseController
    {
        ICarrinhoService _service;

        public CarrinhoController(ICarrinhoService service)
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
            Produtos exists = _service.Get(id);
            return exists == null ?
                ApiNotFound("Não foi encontrado o produto solicitado.") :
                ApiOk(exists);
        }


        //[AuthorizeRoles(RoleType.Admin)]
        [HttpPost]
        public IActionResult Create([FromBody] Produtos prod) =>
            _service.Create(prod, User.Identity.Name) ?
                ApiOk("Produto criado com sucesso!") :
                ApiNotFound("Erro ao criar produto!");

        //[AuthorizeRoles(RoleType.Admin)]
        [HttpPut]
        public IActionResult Update([FromBody] Produtos prod) =>
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
