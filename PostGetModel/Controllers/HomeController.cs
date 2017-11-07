using PostGetModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostGetModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                PessoaId = 1,
                Nome = "Bruno William",
                Twitter = "@BrunoWilliam"
            };

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}
