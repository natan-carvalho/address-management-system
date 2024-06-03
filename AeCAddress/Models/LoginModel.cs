using System.ComponentModel.DataAnnotations;

namespace AeCAddress.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Preencha o campo Usuário")]
        public required string Usuario { get; set; }
        [Required(ErrorMessage = "Preencha o campo Senha")]
        public required string Senha { get; set; }
    }
}