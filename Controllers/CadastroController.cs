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
            return View();
        }

        [Route("Novo")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Random numeroID = new Random();

            Usuario novoUsuario = new Usuario();
            novoUsuario.IdUsuario = numeroID.Next();

            novoUsuario.Nome = form["Nome"];

            string dia = form["Dia"];
            string mes = form["Mes"];
            string ano = form["Ano"];
            string dataNascimento = string.Concat(dia + "/" + mes + "/" + ano); // -> dia/mes/ano
            novoUsuario.DataNascimento = DateTime.Parse( dataNascimento );
            // novoUsuario.DataNascimento = DateTime.Parse(form["Data"]); // Data -> 04/02/2021 <- value
            novoUsuario.Email = form["Email"];
            novoUsuario.Username = form["Username"];
            novoUsuario.Senha = form["Senha"];

            if(form.Files.Count > 0)
            {
                /*Variavel que armazena o arquivo enviada pelo usuário*/
                var file = form.Files[0];
                /*Essa varivel vai combinar (.Combine) o diretorio com a pasta*/
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Feed");

                /*Condicional para ver se pasta "wwwroot/img/" já existe*/
                if(!Directory.Exists(folder))
                {
                    /*folder é a variavel que está ali em cima*/
                    Directory.CreateDirectory(folder);
                }

                /*Variavel para definir o caminho da criação do arquivo*/
                                         //localhost:5001                                //Post   //imagem.jpg
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                /*Utilizada para fechar automaticamente*/
                using(var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novoUsuario.Foto = file.FileName;
            }
            else
            {
                novoUsuario.Foto = "padrao.png";
            }


            usuarioModel.CadastrarUsuario(novoUsuario);

            return LocalRedirect("~/Login");
        }

    }
}