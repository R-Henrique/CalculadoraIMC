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
            {
            if (imc < 17,00)
            Console.WriteLine("Você  está muito abaixo do peso", imc);
            if (imc > = 17,00 && imc < 18,49)
            Console.WriteLine("Você  está abaixo do peso", imc);
            if (imc > = 18,50 && imc < 24,99)
            Console.WriteLine("Você está com peso normal", imc);
            if (imc > = 25,00 && imc < 29,99)
            Console.WriteLine("Você está acima do peso", imc);
            if (imc > = 30,00 && imc < 34,99)
            Console.WriteLine("Você esta com obesidade ");
            if (imc > = 35,99 && imc < 39,99)
            Console.WriteLine("Você esta com obesidade severa ", imc);
            if (imc > 40,00)
            Console.WriteLine("Você esta com  obesidade morbida", imc);
            }
        }
    }
}
