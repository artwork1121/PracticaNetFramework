using NET_Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NET_Framework.Controllers
{
    public class AdministrationController : Controller
    {
        //private List<Card> cars;

        // GET: Administration
        public ViewResult Index()
        {
            List<Card> cards = new List<Card>();
            Card product = new Card(
            "<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"currentColor\" class=\"bi bi-box-seam\" viewBox=\"0 0 16 16\">\r\n  <path d=\"M8.186 1.113a.5.5 0 0 0-.372 0L1.846 3.5l2.404.961L10.404 2l-2.218-.887zm3.564 1.426L5.596 5 8 5.961 14.154 3.5l-2.404-.961zm3.25 1.7-6.5 2.6v7.922l6.5-2.6V4.24zM7.5 14.762V6.838L1 4.239v7.923l6.5 2.6zM7.443.184a1.5 1.5 0 0 1 1.114 0l7.129 2.852A.5.5 0 0 1 16 3.5v8.662a1 1 0 0 1-.629.928l-7.185 2.874a.5.5 0 0 1-.372 0L.63 13.09a1 1 0 0 1-.63-.928V3.5a.5.5 0 0 1 .314-.464L7.443.184z\"/>\r\n</svg>",
            "Productos",
            "Ingrese para ver el listado de productos. Tambien le permite agregar, modificar y borrar articulos.",
            "Products"
            );
            Card product2 = new Card(
            "<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"currentColor\" class=\"bi bi-upc\" viewBox=\"0 0 16 16\">\r\n  <path d=\"M3 4.5a.5.5 0 0 1 1 0v7a.5.5 0 0 1-1 0v-7zm2 0a.5.5 0 0 1 1 0v7a.5.5 0 0 1-1 0v-7zm2 0a.5.5 0 0 1 1 0v7a.5.5 0 0 1-1 0v-7zm2 0a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-7zm3 0a.5.5 0 0 1 1 0v7a.5.5 0 0 1-1 0v-7z\"/>\r\n</svg>",
            "Productos",
            "Ingrese para ver el listado de productos. Tambien le permite agregar, modificar y borrar articulos.",
            "Products2"
            );
            Card product3 = new Card(
            "<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"currentColor\" class=\"bi bi-tags\" viewBox=\"0 0 16 16\">\r\n  <path d=\"M3 2v4.586l7 7L14.586 9l-7-7H3zM2 2a1 1 0 0 1 1-1h4.586a1 1 0 0 1 .707.293l7 7a1 1 0 0 1 0 1.414l-4.586 4.586a1 1 0 0 1-1.414 0l-7-7A1 1 0 0 1 2 6.586V2z\"/>\r\n  <path d=\"M5.5 5a.5.5 0 1 1 0-1 .5.5 0 0 1 0 1zm0 1a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3zM1 7.086a1 1 0 0 0 .293.707L8.75 15.25l-.043.043a1 1 0 0 1-1.414 0l-7-7A1 1 0 0 1 0 7.586V3a1 1 0 0 1 1-1v5.086z\"/>\r\n</svg>",
            "Marcas",
            "Ingrese para ver el listado de productos. Tambien le permite agregar, modificar y borrar articulos.",
            "Brands"
            );
            Card product4 = new Card(
            "<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"currentColor\" class=\"bi bi-tag\" viewBox=\"0 0 16 16\">\r\n  <path d=\"M6 4.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0zm-1 0a.5.5 0 1 0-1 0 .5.5 0 0 0 1 0z\"/>\r\n  <path d=\"M2 1h4.586a1 1 0 0 1 .707.293l7 7a1 1 0 0 1 0 1.414l-4.586 4.586a1 1 0 0 1-1.414 0l-7-7A1 1 0 0 1 1 6.586V2a1 1 0 0 1 1-1zm0 5.586 7 7L13.586 9l-7-7H2v4.586z\"/>\r\n</svg>",
            "Productos",
            "Ingrese para ver el listado de productos. Tambien le permite agregar, modificar y borrar articulos.",
            "Products2"
            );

            cards.Add(product);
            cards.Add(product2);
            cards.Add(product3);
            cards.Add(product4);
            return View(cards);

        }
    }
}