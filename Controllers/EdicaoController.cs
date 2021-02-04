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

        public IActionResult Index()
        {

            return View();
            
        }

        [Route("DeletarConta")]
        public IActionResult DeletarUsuario(int id)
        {
            usuarioModel.DeletarUsuario(id);
            ViewBag.Usuario = usuarioModel.ListarUsuario();

            return LocalRedirect("~/EdicaoPerfil");
        }

        [Route("EditarConta")]
        public IActionResult EditarUsuario(Usuario u)
        {
            usuarioModel.EditarUsuario(u);
            // ViewBag.Usuario = usuarioModel.RewriteCSV(string path, List<string> linhas);

            return LocalRedirect("~/EdicaoPerfil");
        }


    }
}