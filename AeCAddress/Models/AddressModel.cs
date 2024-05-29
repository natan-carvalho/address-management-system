namespace AeCAddress;

public class AddressModel
{
  public int Id { get; set; }
  public required string CEP { get; set; }
  public required string Logradouro { get; set; }
  public string? Complement { get; set; }
  public required string Bairro { get; set; }
  public required string Cidade { get; set; }
  public required string UF { get; set; }
  public required string Numero { get; set; }
  public required int UsuarioID { get; set; }

}
