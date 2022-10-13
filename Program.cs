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

            float v1, v2, result = 0;
            string operador, nomeOperador = "";

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
                    result = Soma(v1, v2);
                    nomeOperador = "soma";
                    break;

                case "-":
                    result = Subtracao(v1, v2);
                    nomeOperador = "subtração";
                    break;

                case "*":
                    result = Multiplicacao(v1, v2);
                    Multiplicacao(v1, v2);
                    nomeOperador = "multiplicação";
                    break;

                case "/":
                    result = Multiplicacao(v1, v2);
                    Divisao(v1, v2);
                    nomeOperador = "divizão";
                    break;

                case "%":
                    result = Multiplicacao(v1, v2);
                    Resto(v1, v2);
                    nomeOperador = "resto";
                    break;

                default:
                    Console.WriteLine("Opção inexistente!");
                    Console.ReadKey();
                    Menu();
                    break;

            }
            Console.WriteLine($"O resultado da {nomeOperador} de {v1} + {v2}, é igual a {result}");
        }

        static float Soma(float v1, float v2)
        {
            float resultado = v1 + v2;
            return resultado;
        }
        static float Subtracao(float v1, float v2)
        {
            float resultado = v1 - v2;
            return resultado;
        }
        static float Multiplicacao(float v1, float v2)
        {
            float resultado = v1 * v2;
            return resultado;
        }
        static float Divisao(float v1, float v2)
        {
            float resultado = v1 / v2;
            return resultado;
        }
        static float Resto(float v1, float v2)
        {
            float resultado = v1 % v2;
            return resultado;
        }
    }
}