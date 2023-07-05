using System.ComponentModel.DataAnnotations;

namespace Microondas.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "digite o login")]
        public string Username { get; set; }
        [Required(ErrorMessage = "digite a senha")]
        public string Password { get; set; }
    }



}
