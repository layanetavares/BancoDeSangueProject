namespace BancoDeSangue.Shared.Models;

public class BolsaSangue
{
    public int BolsaId { get; set; }
    public string CodigoBolsa { get; set; } = string.Empty;
    public string TipoSanguineo { get; set; } = string.Empty;
    public int VolumeMl { get; set; }
    public DateTime DataColeta { get; set; } = DateTime.Now;
    public DateTime DataValidade { get; set; } = DateTime.Now.AddDays(35);
    public string StatusBolsa { get; set; } = "Em Análise"; // Ex: Em Análise, Liberada, Descartada, Consumida
    public int DoadorId { get; set; }
}