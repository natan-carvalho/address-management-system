namespace AeCAddress;

public class UserModel
{
  public int Id { get; set; }
  public required string Nome { get; set; }
  public required string Usuario { get; set; }
  public required string Senha { get; set; }

  public bool PasswordIsValid(string password)
  {
    return Senha == password;
  }
}
