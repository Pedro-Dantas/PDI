using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // área da circuferência

            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;

            Console.WriteLine($"A área é: {area}");

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine($"Está chovendo? {estaChovendo}");

            byte idade = 45;
            Console.WriteLine(idade);

        }
    }
}
