using System;
using System.IO;
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

        [Route("Listar")]
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

        [Route("Cadastrar")]
        public IActionResult CriarPublicacao(IFormCollection form)
        {
            var x = HttpContext.Session.GetString("IdLogado");

            /*Gerar números aleatórios para o ID*/
            Random publicacaoId = new Random();

            Publicacao novaPubli = new Publicacao();

            /*.Next(), pois sempre vai pegar o próximo número da Random*/
            novaPubli.IdPublicacao = publicacaoId.Next();
            novaPubli.Legenda = form["inserir-legenda"];
            novaPubli.Imagem = form["inserir-imagem"];

            /*Condicional para verificação de existencia de arquivo*/
            if(form.Files.Count > 0)
            {
                /*Variavel que armazena o arquivo enviada pelo usuário*/
                var file = form.Files[0];
                /*Essa varivel vai combinar (.Combine) o diretorio com a pasta*/
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Feed");

                /*Condicional para ver se pasta "wwwroot/img/" já existe*/
                if(!Directory.Exists(folder))
                {
                    /*folde é a variavel que está ali em cima*/
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

                novaPubli.Imagem = file.FileName;
            }
            else
            {
                novaPubli.Imagem = "padraoPostagem.png";
            }

            novaPubli.IdUsuario = int.Parse(x);
            novaPubli.Likes = 0;

            return LocalRedirect("~/Feed");
        }

    }
}