using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu peso: ");
            string pesoEmString = Console.ReadLine();

            Console.WriteLine("Informe sua altura");
            string alturaEmString = Console.ReadLine();

            float peso = float.Parse(pesoEmString);
            float altura = float.Parse(alturaEmString);

            float imc = CalcularIMC(altura, peso);

            ExibirIMC(imc);
            
            Console.ReadLine();

        }

        private static float CalcularIMC(float altura, float peso)
        {
            return peso / (altura * altura);
        }

        private static void ExibirIMC(float imc)
        {
            if (imc <= 16)
                Console.WriteLine("Magreza moderada");
            else if (imc <= 18)
                Console.WriteLine("Magreza moderada");
            else if (imc <= 18.4)
                Console.WriteLine("Magreza leve");
            else if (imc <= 24)
                Console.WriteLine("saudável");
            else if (imc <= 29)
                Console.WriteLine("sobrepeso");
            else if (imc <= 34)
                Console.WriteLine("grau 1");
            else if (imc <= 40)
                Console.WriteLine("grau 2");
            else
                Console.WriteLine("grau 3");

            /*
            40 - 35 = grau 2
            34 - 30 = grau 1
            29 - 25 = sobrepeso
            24 - 18.5 = saudável
            18.4 - 17 = magreza leve
            */


        }

    }
}
