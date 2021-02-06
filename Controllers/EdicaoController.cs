using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    // [Route("EdicaoPerfil")]
    public class EdicaoController : Controller
    {
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {

            return View();
            
        }

        [Route("DeletarUsuario")]
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

            usuarioModel.EditarUsuario(editarUsuario);

            return LocalRedirect("~/Perfil");
        }


    }
}