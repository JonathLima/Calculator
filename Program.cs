using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res){
                case 1: Soma(); break;
                case 2: Subtration(); break;
                case 3: Multiply(); break;
                case 4: Division(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma(){
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor:" );
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float soma = n1 + n2;
            Console.WriteLine($"A soma dos valores é {soma}");
            Console.ReadKey();
            Menu();
        }
        static void Subtration(){
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor:" );
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float sub = n1 - n2;
            Console.WriteLine($"A subtração dos valores é {sub}");
            Console.ReadKey();
            Menu();
        }
        static void Multiply(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float multiply = n1 * n2;
            Console.WriteLine($"A multiplicação dos valores é {multiply.ToString("F2")}");
            Console.ReadKey();
            Menu();
        }
        static void Division(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float division = n1 / n2;
        
            Console.WriteLine($"A divisão entre os dois valores é {division.ToString("F2")}");
            Console.ReadKey();
            Menu();
        }
            
    }
}
