using Microsoft.AspNetCore.Mvc;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {

        public IActionResult Index()
        {

            return View();

        }

    }
}