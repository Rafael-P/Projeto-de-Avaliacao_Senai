using Microsoft.AspNetCore.Mvc;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {

            return View();

        }
    }
}