using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar() 
        {
            double somatorio = 0;
        
            Console.WriteLine("Informe o tamanho da turma: ");

            int.TryParse(Console.ReadLine(), out int tamanhoDaTurma);

            for (int i = 1; i <= tamanhoDaTurma; i++)
            {
                Console.WriteLine($"Informe a nota do aluno[{i}]: ");
                Double.TryParse(Console.ReadLine(), out double notaAtual);
                somatorio += notaAtual;
            }

            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine($"A média da turma é {media}.");
        }
    }
}
