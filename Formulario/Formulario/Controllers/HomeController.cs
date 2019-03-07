using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.oreo = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nome, int idade)
        {
            //criar a mensagem de resposta
            string mensagem = "voce chama se "+nome+" e tem "+idade+" anos.";
            //criar o 'contetor' que levara a mensagem para a view
            ViewBag.oreo = mensagem;
            //invoca a view
            return View();
        }
    }
}