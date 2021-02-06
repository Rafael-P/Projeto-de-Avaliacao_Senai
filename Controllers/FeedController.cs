using Microsoft.AspNetCore.Http;
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

            var x = HttpContext.Session.GetString("IdLogado");

            ViewBag.Logado = usuarioModel.BuscarPorId(int.Parse(x));  

            /*A ViewBag pode ter o nome que você escolher*/
            /*Chamamos na ViewBag.Usuarios e ViewBag.Postagem a função Listar de cada um*/
            ViewBag.Usuarios = usuarioModel.ListarUsuario();
            ViewBag.Postagem = publicacaoModel.ListarPublicacoes();
            /*Nessa ViewBag abaixo, instanciamos as models necessarias*/
            ViewBag.Comentarios = new Comentario();
            ViewBag.objUsuario = new Usuario();
            
            return View(); 
        }
    }
}