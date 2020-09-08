using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;

            Console.WriteLine("Entre com a nota do aluno: ");
            Double.TryParse(Console.ReadLine(), out double notaDoAluno);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            string entrada = Console.ReadLine();

            //  if (entrada == "S" || entrada == "s")
            //      bomComportamento = true;

            //  bomComportamento = entrada == "S" || entrada == "s";

            //  if (notaDoAluno >= 9.0 && bomComportamento)
            //  {
            //      Console.WriteLine("Quadro de honra!");
            //  }

            bomComportamento = entrada.ToLower() == "s";

            string StatusAluno = notaDoAluno >= 9.0 && bomComportamento ? "Quadro de honra!" : "Sem quadro de honra!";

            Console.WriteLine(StatusAluno);
        }
    }
}
