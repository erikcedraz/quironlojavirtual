using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web;
using Quiron.LojaVirtual.Web.Models;
using Quiron.LojaVirtual.Web.HtmlHelpers;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void Take()
        {
            //O operador Take é usado para selecionar os primeiros n objetos de uma coleção.

            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5) select num;

            int[] teste = { 5, 4, 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }



        [TestMethod]
        public void Skip()
        {
            //O operador Skip ignora o(s) primeiro(s) n objetos de uma coleção.

            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = { 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        [TestMethod]
        public void TestarPaginacao()
        {
            // Arrage por primeiro
            HtmlHelper html = null;

            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensTotal = 28,
                ItensPorPagina = 10
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            //Act Consumir o sistema, preencher

            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            //Assert

            Assert.AreEqual
                (
                      @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                    + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                    + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>",resultado.ToString()
                );
        }
    }
}
