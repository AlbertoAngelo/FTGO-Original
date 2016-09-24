using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodTruck.Controllers
{
    public class Avaliação_SemLoginController : Controller
    {
        // GET: Avaliação_SemLogin
        public ActionResult AvaliarFT_SL()
        {
            return View();
        }
    }
}