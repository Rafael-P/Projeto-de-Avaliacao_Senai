using Microsoft.AspNetCore.Mvc;

namespace Projeto_de_Avaliacao_Senai.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        
        public IActionResult Index(){

            return View();
            
        }
    }
}