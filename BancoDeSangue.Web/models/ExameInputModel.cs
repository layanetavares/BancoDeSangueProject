using System.ComponentModel.DataAnnotations;

namespace BancoDeSangue.Web.Models;

public class ExameInputModel
{
    [Required(ErrorMessage = "O ID da bolsa é obrigatório")]
    public int BolsaId { get; set; }

    [Required(ErrorMessage = "Informe o tipo de teste")]
    public string TipoExame { get; set; } = string.Empty; // ex: HIV, Hepatite B, Hepatite C, Chagas, Sífilis, HTLV

    public bool Reagente { get; set; } // true = Reagente (Positivo), false = Não Reagente (Negativo)
    
    public string Obsercoes { get; set; } = string.Empty;
}