using System.ComponentModel.DataAnnotations;
using AeCAddress.Helpers;

namespace AeCAddress;

public class UserModel
{
  public int Id { get; set; }
  [Required(ErrorMessage = "Preencha o campo Nome!")]
  public required string Nome { get; set; }
  [Required(ErrorMessage = "Preencha o campo Usuário!")]
  public required string Usuario { get; set; }
  [Required(ErrorMessage = "Preencha o campo Senha!")]
  public required string Senha { get; set; }

  public bool PasswordIsValid(string password)
  {
    return Senha == password;
  }

  public void SetPasswordHash()
  {
    Senha = Senha.Hash();
  }
}
