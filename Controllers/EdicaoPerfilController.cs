using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    public class EdicaoPerfilController : Controller
    {
        [Route("Edicao")]
        public IActionResult EdicaoPerfil()
        {
            return View();
        }


    }
}