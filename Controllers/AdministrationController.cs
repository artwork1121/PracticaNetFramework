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
            "<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"currentColor\" class=\"bi bi-house\" viewBox=\"0 0 16 16\">\r\n  <path fill-rule=\"evenodd\" d=\"M2 13.5V7h1v6.5a.5.5 0 0 0 .5.5h9a.5.5 0 0 0 .5-.5V7h1v6.5a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 13.5zm11-11V6l-2-2V2.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5z\"/>\r\n  <path fill-rule=\"evenodd\" d=\"M7.293 1.5a1 1 0 0 1 1.414 0l6.647 6.646a.5.5 0 0 1-.708.708L8 2.207 1.354 8.854a.5.5 0 1 1-.708-.708L7.293 1.5z\"/>\r\n</svg>",
            "Inicio",
            "Ir al inicio.",
            "Home"
            );
            Card product2 = new Card(
            "<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"currentColor\" class=\"bi bi-upc\" viewBox=\"0 0 16 16\">\r\n  <path d=\"M3 4.5a.5.5 0 0 1 1 0v7a.5.5 0 0 1-1 0v-7zm2 0a.5.5 0 0 1 1 0v7a.5.5 0 0 1-1 0v-7zm2 0a.5.5 0 0 1 1 0v7a.5.5 0 0 1-1 0v-7zm2 0a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-7zm3 0a.5.5 0 0 1 1 0v7a.5.5 0 0 1-1 0v-7z\"/>\r\n</svg>",
            "Productos",
            "Ingrese para ver el listado de productos. Tambien le permite agregar, modificar y borrar articulos.",
            "Products"
            );
            Card product3 = new Card(
            "<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"currentColor\" class=\"bi bi-tags\" viewBox=\"0 0 16 16\">\r\n  <path d=\"M3 2v4.586l7 7L14.586 9l-7-7H3zM2 2a1 1 0 0 1 1-1h4.586a1 1 0 0 1 .707.293l7 7a1 1 0 0 1 0 1.414l-4.586 4.586a1 1 0 0 1-1.414 0l-7-7A1 1 0 0 1 2 6.586V2z\"/>\r\n  <path d=\"M5.5 5a.5.5 0 1 1 0-1 .5.5 0 0 1 0 1zm0 1a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3zM1 7.086a1 1 0 0 0 .293.707L8.75 15.25l-.043.043a1 1 0 0 1-1.414 0l-7-7A1 1 0 0 1 0 7.586V3a1 1 0 0 1 1-1v5.086z\"/>\r\n</svg>",
            "Marcas",
            "Ingrese para ver el listado de Marcas. Tambien le permite agregar, modificar y borrar articulos.",
            "Brands"
            );
            Card product4 = new Card(
            "<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"currentColor\" class=\"bi bi-building\" viewBox=\"0 0 16 16\">\r\n  <path fill-rule=\"evenodd\" d=\"M14.763.075A.5.5 0 0 1 15 .5v15a.5.5 0 0 1-.5.5h-3a.5.5 0 0 1-.5-.5V14h-1v1.5a.5.5 0 0 1-.5.5h-9a.5.5 0 0 1-.5-.5V10a.5.5 0 0 1 .342-.474L6 7.64V4.5a.5.5 0 0 1 .276-.447l8-4a.5.5 0 0 1 .487.022zM6 8.694 1 10.36V15h5V8.694zM7 15h2v-1.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5V15h2V1.309l-7 3.5V15z\"/>\r\n  <path d=\"M2 11h1v1H2v-1zm2 0h1v1H4v-1zm-2 2h1v1H2v-1zm2 0h1v1H4v-1zm4-4h1v1H8V9zm2 0h1v1h-1V9zm-2 2h1v1H8v-1zm2 0h1v1h-1v-1zm2-2h1v1h-1V9zm0 2h1v1h-1v-1zM8 7h1v1H8V7zm2 0h1v1h-1V7zm2 0h1v1h-1V7zM8 5h1v1H8V5zm2 0h1v1h-1V5zm2 0h1v1h-1V5zm0-2h1v1h-1V3z\"/>\r\n</svg>",
            "Compañia",
            "Ver y modificar la informacion de nuestra empresa.",
            "Company"
            );

            cards.Add(product);
            cards.Add(product2);
            cards.Add(product3);
            cards.Add(product4);
            return View(cards);

        }
    }
}