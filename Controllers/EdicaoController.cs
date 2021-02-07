using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("EdicaoPerfil")]
    public class EdicaoController : Controller
    {
        Usuario usuarioModel = new Usuario();
        Publicacao publicacaoModel = new Publicacao();
        Comentario comentarioModel = new Comentario(); 

        public IActionResult Index()
        {
            var x = HttpContext.Session.GetString("IdLogado");

            ViewBag.Logado = usuarioModel.MostrarUsuario(int.Parse(x));  

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

        [Route("Usuario/{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            usuarioModel.DeletarUsuario(id);

            return LocalRedirect("~/Login");
        }

        [Route("EditarConta")]
        public IActionResult EditarUsuario(IFormCollection form)
        {
            Usuario editarUsuario   = new Usuario();
            editarUsuario.Nome      = form["Nome"];
            editarUsuario.Username  = form["Username"];
            editarUsuario.Email     = form["Email"];
            editarUsuario.Foto      =form["Foto"];
            

            usuarioModel.EditarUsuario(editarUsuario);

            return LocalRedirect("~/Perfil");
        }

        



    }
}