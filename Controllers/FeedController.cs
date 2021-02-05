using Microsoft.AspNetCore.Mvc;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {

        /*Foi criado as instância necessarias*/
        Usuario usuarioModel = new Usuario();
        Publicacao publicacaoModel = new Publicacao();

        public IActionResult Index(){
            /*Foi listados todas as equipes e enviados para View, atráves da ViewBag*/
            ViewBag.Usuarios = usuarioModel.ListarUsuario();
            ViewBag.Postagem = publicacaoModel.ReadAll();
            return View();
            
        }
    }
}