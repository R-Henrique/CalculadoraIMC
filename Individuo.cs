public class Individuo ;
{
    public double Altura{get; set; }
    public double Peso{get; set; }
    public double IMC {get => Peso/(Altura * Altura)}
}