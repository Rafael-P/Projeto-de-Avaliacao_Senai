using Microsoft.AspNetCore.Mvc;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("Perfil")]

    public class PerfilController : Controller
    {
        Usuario usuarioModel       = new Usuario();
        Publicacao publicaoModel   = new Publicacao();
        Comentario comentarioModel = new Comentario();

        public IActionResult Index()    
        {
            ViewBag.Usuario = usuarioModel.ReadAll();
            
            ViewBag.Comentarios = new Comentario();

            return View();
        }
    }
}