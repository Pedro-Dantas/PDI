using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada {notaTruncada}");

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida é {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Idade inserida é {idadeInteiro}");

            Console.WriteLine("Digite um número: ");
            string palavra = Console.ReadLine();
            //int numero1;
            int.TryParse(palavra, out int numero1);
            Console.WriteLine($"O resultado 1 é {numero1}");

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"O resultado 2 é {numero2}");

        }
    }
}
