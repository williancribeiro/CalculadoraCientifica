using System;
using System.Reflection;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione qual tipo de operação você deseja: ");
            Console.WriteLine("0 - Sair do Sistema");
            Console.WriteLine("1 - Fatorial");
            Console.WriteLine("2 - Logaritmo");
            Console.WriteLine("3 - Porcentagem");
            Console.WriteLine("4 - Raíz");
            Console.WriteLine("5 - Potenciação");

            Console.WriteLine("<======================>");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("<======================>");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 0: System.Environment.Exit(0); break;

                case 1: Fatorial(); break;
                case 2: Log(); break;
                case 3: Porcentagem(); break;
                case 4: Raiz(); break;
                case 5: Potencia(); break;
                default: Menu(); break;
            }

        }
        static void Fatorial()
        {
            Console.Clear();
            Console.WriteLine("Digite um número inteiro para calcular o fatorial: ");

            int v1 = int.Parse(Console.ReadLine());

            int resultado = 1;

            for (int i = 1; i <= v1; i++)
            {
                resultado *= i;
            }

            Console.WriteLine($"O resultado fatorial de {v1} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Porcentagem()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 * (v2 / 100);

            Console.WriteLine($"{v2}% de {v1} é :{resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Log()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor do Log: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = Math.Log(v1, v2);

            Console.WriteLine($"O log de {v1} na base {v2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Raiz()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");

            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = Math.Pow(v1, 1.0 / v2);

            Console.WriteLine($"A raíz {v2} de {v1} é: " + resultado);

            Console.ReadKey();
            Menu();
        }

        static void Potencia()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor do algarismo: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da potência: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = Math.Pow(v1, v2);

            Console.WriteLine("A potência de " + v1 + " é: " + resultado);
            Console.ReadKey();
            Menu();
        }
    }
}
