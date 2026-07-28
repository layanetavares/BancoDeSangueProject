public class ConsumoBolsa
{
    public int ConsumoId { get; set; }
    public int BolsaId { get; set; }
    public string HospitalSolicitante { get; set; } = string.Empty;
    public string NomeReceptor { get; set; } = string.Empty;
    public string MedicoResponsavel { get; set; } = string.Empty;
    public string CRM { get; set; } = string.Empty;
    public DateTime DataTransfusao { get; set; } = DateTime.Now;
}