using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    public class CadastroController : Controller
    {
        
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            ViewBag.Usuarios = usuarioModel.ListarUsuario();
            return View();
        }
        public IActionResult Cadastrar(IFormCollection form)
        {
            Random numeroID = new Random();

            Usuario novoUsuario        = new Usuario();
            novoUsuario.IdUsuario      = numeroID.Next();
            novoUsuario.Nome           = form["Nome"];

            string dia                 = form["Dia"];
            string mes                 = form["Mes"];
            string ano                 = form["Ano"];
            string dataNascimento      = string.Concat(dia + "/" + mes + "/" + ano); // -> dia/mes/ano
            novoUsuario.DataNascimento = DateTime.Parse(dataNascimento);
            // novoUsuario.DataNascimento = DateTime.Parse(form["Data"]); // Data -> 04/02/2021 <- value
            novoUsuario.Email          = form["Email"];
            novoUsuario.Username       = form["Username"];
            novoUsuario.Senha          = form["Senha"];

            usuarioModel.CadastrarUsuario(novoUsuario);            
            ViewBag.Usuarios = usuarioModel.ListarUsuario();

            return LocalRedirect("~/Feed");
        }
    }
}