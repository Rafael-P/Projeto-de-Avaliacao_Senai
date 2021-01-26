using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("Edicao")]
    public class EdicaoPerfilController : Controller
    {
        public IActionResult EdicaoPerfil()
        {
            return View();
        }

    [Route("Excluir")]
        public IActionResult Excluir(string email)
        {
            usuarioModel.Delete(email);
            return LocalRedirect("~/Home");
        }



    }
}