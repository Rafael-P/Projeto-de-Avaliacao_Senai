using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
        [Route("Cadastrar")]
         public class CadastroController : Controller
        {
        
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            ViewBag.Usuarios = usuarioModel.ListarUsuario();
            return View();
        }
        [Route("Novo")]
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

            Imagem novaImagem        = new Imagem();

            if(form.Files.Count > 0)
            {

                // Upload Início
                var file    = form.Files[0];
                var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img");

                if(!Directory.Exists(folder)){
                    Directory.CreateDirectory(folder);
                }
                
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    file.CopyTo(stream);  
                }
                novaImagem.Imagens   = file.FileName;                
            }
            else
            {
                novaImagem.Imagens  = "padrao.png";
            }

            return LocalRedirect("~/Perfil ");
        }

        
    }
}