using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar() 
        {
            // return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos!");

            string apresentar = Nome != null && Idade > 0 ? $"Olá! Me chamo {Nome} e tenho {Idade} anos!" : "Nome e idade não preenchidos!";

            return apresentar;
        }

        public void ApresentarNoConsole() 
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() 
        {
            Nome = "";
            Idade = 0;
        }
    }
}
