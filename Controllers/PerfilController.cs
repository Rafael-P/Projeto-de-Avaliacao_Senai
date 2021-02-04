using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()    
        {
            ViewBag.Usuario = usuarioModel.Readall();
            return View();
        }

    }
}