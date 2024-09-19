namespace AppIlhabela.Models
{
    public class Praias
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? descriçao { get; set; }
        public double? preços { get; set; }
        public string? subtit {  get; set; }
        public string? imagem { get; set; }
        public string? Url { get; set; }

        public List<ComoChegar>? chegar { get; set; }
    }
}
