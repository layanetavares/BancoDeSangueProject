namespace BancoDeSangue.API.Models
{
    public class Exame
    {
        public int Id { get; set; }
        public string BolsaId { get; set; } = string.Empty;
        public DateTime DataExame { get; set; } = DateTime.Now;
        public bool Hiv { get; set; }
        public bool HepatiteB { get; set; }
        public bool HepatiteC { get; set; }
        public bool Chagas { get; set; }
        public bool Sifilis { get; set; }
        public bool Htlv { get; set; }
        public string ResultadoGlobal { get; set; } = "NAO_REATIVO";
    }
}