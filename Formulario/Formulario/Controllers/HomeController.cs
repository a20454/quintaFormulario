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
        public ActionResult Index(string nome, int? idade)
        {
            ///precisamos de validar os dados introduzidos pelo utilizador
            ///1º questao: o nome é um nome?
            ///2º questao: a idade esta dentro do parametros pretendidos?

            string mensagem = "";

            //validar a idade
            if (idade >= 0 && idade <= 120)
            {

                //criar a mensagem de resposta
                mensagem = "voce chama se " + nome + " e tem " + idade + " anos.";
            }
            else
            {
                //mensagem alternativa
                mensagem = "idade invalida\n"+"entre os 0 e 120 anos";
            }
            //criar o 'contetor' que levara a mensagem para a view
            ViewBag.oreo = mensagem;
            //invoca a view
            return View();
        }
    }
}