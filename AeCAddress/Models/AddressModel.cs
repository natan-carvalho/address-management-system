using System.ComponentModel.DataAnnotations;

namespace AeCAddress;

public class AddressModel
{
  public int Id { get; set; }

  [Required(ErrorMessage = "O campo CEP não pode ser vazio!")]
  public required string CEP { get; set; }
  [Required(ErrorMessage = "O campo Logradouro não pode ser vazio!")]
  public required string Logradouro { get; set; }
  [Required(ErrorMessage = "O campo Complemento não pode ser vazio!")]
  public required string? Complement { get; set; }
  [Required(ErrorMessage = "O campo Bairro não pode ser vazio!")]
  public required string Bairro { get; set; }
  [Required(ErrorMessage = "O campo Cidade não pode ser vazio!")]
  public required string Cidade { get; set; }
  [Required(ErrorMessage = "O campo Estado não pode ser vazio!")]
  public required string UF { get; set; }
  [Required(ErrorMessage = "O campo Numero não pode ser vazio!")]
  public required string Numero { get; set; }
  [Required(ErrorMessage = "Usuário invalido")]
  public required int UsuarioID { get; set; }

  public override string ToString()
  {
    return $"{Id}; {CEP}; {Logradouro}; {Complement}; {Bairro}; {Cidade}; {UF}; {Numero}";
  }
}
