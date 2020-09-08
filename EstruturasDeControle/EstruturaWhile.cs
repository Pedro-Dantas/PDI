using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            Random random = new Random();
            int palpite = 0;

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira seu palpite: ");
                int.TryParse(Console.ReadLine(), out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Número encontrado em {tentativas} tentativas!");
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                }
                else 
                {
                    Console.WriteLine("Maior... tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                }
            }
        }
    }
}
