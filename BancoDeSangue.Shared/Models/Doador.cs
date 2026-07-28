namespace BancoDeSangue.Shared.Models;

public class Doador
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string TipoSanguineo { get; set; } = string.Empty;
    public bool Apto { get; set; }
}