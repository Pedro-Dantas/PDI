﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Qual é o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine($"Bem vindo {entrada}!");
                Console.WriteLine("Deseja continuar?(S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");
        }
    }
}
