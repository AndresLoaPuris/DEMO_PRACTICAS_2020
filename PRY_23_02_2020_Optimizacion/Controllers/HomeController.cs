using PRY_23_02_2020_Optimizacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRY_23_02_2020_Optimizacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			using (MyDataEntities db = new MyDataEntities()) {
				var data = db.Persona.OrderBy(X => X.Id).ToList();
				return View(data);
			}
				
        }
    }
}