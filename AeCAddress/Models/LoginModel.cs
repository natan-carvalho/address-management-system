using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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