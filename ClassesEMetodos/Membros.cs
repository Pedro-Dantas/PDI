using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar() 
        {
            Pessoa pedro = new Pessoa();

            pedro.Nome = "Pedro Dantas";
            pedro.Idade = 22;

            //  Console.WriteLine($"{pedro.Nome} tem {pedro.Idade} anos.");

            pedro.ApresentarNoConsole();
            pedro.Zerar();
            pedro.ApresentarNoConsole();

            var fulana = new Pessoa();
            fulana.Nome = "Ariana";
            fulana.Idade = -21;

            var apresentacaoDaFulana = fulana.Apresentar();
            Console.WriteLine(apresentacaoDaFulana.Length);
            Console.WriteLine(apresentacaoDaFulana);



        }
    }
}
