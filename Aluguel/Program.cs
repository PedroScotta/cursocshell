using System;
using System.Globalization;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroDeAluguel[] vet = new RegistroDeAluguel[10];
            string nome, email;
            int quarto;

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto? ");
                quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new RegistroDeAluguel (nome, email);
                Console.WriteLine();
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0;i < 10;i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ", " + vet[i]);
                }
            }
        }
    }
}