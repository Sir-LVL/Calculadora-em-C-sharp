using System;

namespace Metodo
{
    class Mudar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voce quer fazer qual operação Matemática com esses números?\n + Adição\t - Subtração\t * Multiplicação\t / Divisão\n ");
            string ope = Console.ReadLine();
            switch (ope)
            {
                case "+":
                    int adicao = num1 + num2;
                    Console.WriteLine($"O valor da soma de {num1} e {num2} é {adicao}");
                    break;
                case "-":
                    int sub = num1 - num2;
                    Console.WriteLine($"O Valor da subtração de {num1} e {num2} é {sub}");
                    break;
                case "*":
                    int multi = num1 * num2;
                    Console.WriteLine($"O valor da multiplicação de {num1} e {num2} é {multi}");
                    break;
                case "/":
                    decimal divi = num1 / num2;
                    Console.WriteLine($"O Valor da divisão de {num1} e {num2} é {divi}");
                    break;
            }

            
        }
    }
}