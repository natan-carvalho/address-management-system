using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeCAddress.Models
{
    public class LoginModel
    {
        public required string Usuario { get; set; }
        public required string Senha { get; set; }
    }
}