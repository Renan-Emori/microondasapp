using Microondas.Models;
using Microondas.Repository;
using Microondas.Services;
using Microsoft.AspNetCore.Mvc;

namespace Microondas.Controllers
{

    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();  
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync(User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);
            try
            {
                if (user != null)
                {
                    var token = TokenService.GenerateToken(user);
                    //return RedirectToAction("Inicio", "Configurar");
                    return Ok(new { token = token}) ;
                } 
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível fazer o cadastro, detalhe do erro: {erro.Message}";
                return RedirectToAction("Configurar");
            }
        }                   
    }
}

 