using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? EX: 1,63");
            float altura = Convert.ToSingle(Console.ReadLine());

             Console.WriteLine("Qual a seu peso em kg? EX: 59,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine(
                "{0} sua altura é {1} e seu peso {2}",
                nome, altura, peso
            );

            Console.WriteLine("Seu IMC é {0}", imc);
        }
    }
}
