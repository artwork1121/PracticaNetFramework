using AccDatos;
using NET_Framework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NET_Framework.Controllers
{
	public class HomeController : Controller
	{
		//private readonly MyContext _myContext = new MyContext();
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			return View();
		}
	}
}