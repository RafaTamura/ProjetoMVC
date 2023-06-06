using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ProjetoMVC.Controllers
{
    public class Hello : Controller
    {
        public IActionResult Index()
        //public string Index()
        {
            return View();
            //return "Apresenta essa mensagem";
        }
        public IActionResult Welcome(string nome, int numTimes = 10)
        {
            ViewData["Message"] = "Oi" + nome;
            ViewData["NumTimes"] = numTimes;
            //return HtmlEncoder.Default.Encode($"Oi {nome}, ID: {ID}");
            return View();
        }
        public string Teste()
        {
            return "Outro";
        }
    }
}
