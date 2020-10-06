using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método de instância
        public int Somar(int a, int b)
        {
            return a + b;
        }

        // Método de classe ou estático
        public static int Multiplcar(int a, int b) 
        {
            return a * b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar() 
        {
            var resultado = CalculadoraEstatica.Multiplcar(2, 2);
            Console.WriteLine(resultado);

            CalculadoraEstatica calculadoraEstatica = new CalculadoraEstatica();

            Console.WriteLine(calculadoraEstatica.Somar(2, 2));
        }
    }
}
