
using API_Pneus.API;
using API_Pneus.Services;
using API_Pneus.Controllers;
using API_Pneus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;

namespace PneusTeste
{
    public class PneuControlerTeste
    {

        int PneusQuantity = 10;
        List<Produtos> fakePneus; 
        public PneuControlerTeste()
        {
            fakePneus = new List<Produtos>();
            for(var i = 1; i <= PneusQuantity; i++)
            {
                fakePneus.Add(new Produtos { Id = i, NomeProd = $"Prod {i}" });
            }
        }
        [Fact]
        public void GetPneus_Returns_The_Correct_Pneus()
        {
            var productServices = A.Fake<IProdutosService>();
            A.CallTo(() => productServices.All()).Returns(fakePneus);
            var controller = new ProdutosController(productServices);

            OkObjectResult result = controller.Index() as OkObjectResult;
            var values = result.Value as APIResponse<List<Produtos>>;

            Assert.True(
                values.Results == fakePneus &&
                values.Message == "" &&
                values.Succeed
                );

        }
        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void GetProdutos_Return_Produtos_By_Id(int? id, string message = "", bool succeed = true)
        {
            var productService = A.Fake<IProdutosService>();
            A.CallTo(() => productService.Get(id)).Returns(fakePneus.Find(p => p.Id == id));

            var controller = new ProdutosController(productService);
            ObjectResult result = controller.Index(id) as ObjectResult;

            var exist = fakePneus.Find(p => p.Id == id) != null;

            if (exist)
            {
                var values = result.Value as APIResponse<Produtos>;
                Assert.True(
                    values.Succeed == succeed &&
                    values.Message == message &&
                    values.Results == fakePneus.Find(p => p.Id == id)
                    
                    );
            }
            else
            {
                var values = result.Value as APIResponse<string>;
                Assert.True(
                    values.Succeed == succeed &&
                    values.Message == message &&
                    values.Results == null
                    );
            }
        }

    }
}
