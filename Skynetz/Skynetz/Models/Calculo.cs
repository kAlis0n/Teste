namespace Skynetz.Models
{
    public class Calculo
    {
        public string DDDsSelecionado { get; set; }
        public int PlanoSelecionado { get; set; }
        public int Minutos { get; set; }
        public decimal CustoComPlano { get; set; }
        public decimal CustoSemPlano { get; set; }
        public List<Tarifa> Tarifas { get; set; }
        public List<Plano> Planos { get; set; }
    }
}
