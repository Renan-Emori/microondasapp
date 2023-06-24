using Microondas.Models;
using Microondas.Repository;
using Microondas.Services;
using Microsoft.AspNetCore.Mvc;

namespace Microondas.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);
            if (user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos"});
            }
            else
            {
            var token = TokenService.GenerateToken(user);
            return new
            {
                user = user,
                token = token
            };
            }

            }
        }

    }