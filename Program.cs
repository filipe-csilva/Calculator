using System;

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

            float v1, v2;
            string operador,nomeOperador;

            Console.WriteLine("Primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador: ");
            operador = Console.ReadLine();

            Console.WriteLine("Segundo valor: ");
            v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            switch (operador)
            {
                case "+":
                    Soma(v1, v2);
                    nomeOperador = "soma";
                    break;

                case "-":
                    Subtracao(v1, v2);
                    nomeOperador = "soma";
                    break;

                case "*":
                    Multiplicacao(v1, v2);
                    nomeOperador = "soma";
                    break;

                case "/":
                    Divisao(v1, v2);
                    nomeOperador = "soma";
                    break;

                case "%":
                    Resto(v1, v2);
                    nomeOperador = "soma";
                    break;

                default:
                    Console.WriteLine("Opção inexistente!");
                    Console.ReadKey();
                    Menu();
                    break;

            }
        }

        static void Soma(float v1, float v2)
        {
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma de {v1} + {v2}, é igual a {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao(float v1, float v2)
        {
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da Subtração de {v1} - {v2}, é igual a {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao(float v1, float v2)
        {
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da Multiplicação de {v1} * {v2}, é igual a {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao(float v1, float v2)
        {
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da Divisão de {v1} / {v2}, é igual a {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Resto(float v1, float v2)
        {
            float resultado = v1 % v2;
            Console.WriteLine($"O resultado da Resto de {v1} e {v2}, é igual a {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}