using System.Collections.Generic;
using System.IO;
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
            editarUsuario.Foto      = form["Foto"];
            editarUsuario.IdUsuario  =int.Parse(form["Id"]); 
             

              if(form.Files.Count > 0)
            {
                /*Variavel que armazena o arquivo enviada pelo usuário*/
                var file = form.Files[0];
                /*Essa varivel vai combinar (.Combine) o diretorio com a pasta*/
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/");

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

                editarUsuario.Foto = file.FileName;
            }
            else
            {
                editarUsuario.Foto = form["Foto2"];
            }

            usuarioModel.EditarUsuario(editarUsuario);

            return LocalRedirect("~/Perfil");
        }

        



    }
}