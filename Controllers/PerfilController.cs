using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {
         /*Foi criado as instância necessarias*/
        Usuario usuarioModel = new Usuario();
        Publicacao publicacaoModel = new Publicacao();
        Comentario comentarioModel = new Comentario(); 

        public IActionResult Index()    
        {
            var x = HttpContext.Session.GetString("IdLogado");

            ViewBag.Logado = usuarioModel.MostrarUsuario(int.Parse(x));

            ViewBag.Post = publicacaoModel.BuscarPorId(int.Parse(x));
            /*A ViewBag pode ter o nome que você escolher*/
            /*Chamamos na ViewBag.Usuarios e ViewBag.Postagem a função Listar de cada um*/
            ViewBag.Usuarios = usuarioModel.ListarUsuario();
            ViewBag.Postagem = publicacaoModel.ListarPublicacoes();
            /*Nessa ViewBag abaixo, instanciamos as models necessarias*/
            ViewBag.Comentarios = new Comentario();
            ViewBag.objUsuario = new Usuario();
                    
            //ViewBag.Usuario = usuarioModel.ListarUsuario();
            return View();
        }

        [Route("Perfil/{id}")]
        public IActionResult ExcluirComentario(int IdComentario)
        {
            comentarioModel.ExcluirComentario(IdComentario);

            return LocalRedirect("~/Perfil");
        }

    }
}