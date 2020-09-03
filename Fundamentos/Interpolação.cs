using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolação
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preço = 5800.00;

            Console.WriteLine("O " + nome + " da marca "
                + marca + " que custa " + preço + ".");

            Console.WriteLine($"A marca {marca} do {nome} custa {preço}!");
        }
    }
}
