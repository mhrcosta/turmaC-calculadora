using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20170317_calculadoraCompleta.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            return View();
        }


        // POST: Home
        /// <summary>
        /// recebe os dados da View e processa-os
        /// com vista a calcular o resultado a apresentar
        /// ao utilizador
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(
            string bt) {





            return View();
        }
    }
}