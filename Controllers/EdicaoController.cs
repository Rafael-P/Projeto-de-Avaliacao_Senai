using Microsoft.AspNetCore.Mvc;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("EdicaoPerfil")]
    public class EdicaoController : Controller
    {

        public IActionResult Index()
        {

            return View();
            
        }


    }
}