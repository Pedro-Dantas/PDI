using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro() { }

        public Carro(string modelo, string fabricante, int ano) 
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public void Imprimir() 
        {
            Console.WriteLine($"{Fabricante} {Modelo} {Ano}");
        }
    }

    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            carro1.Imprimir();
            
            Carro carro2 = new Carro("Uno", "Fiat", 2017);
            carro2.Imprimir();

            Carro carro3 = new Carro() 
            { 
                Modelo = "Ka",
                Fabricante = "Fiat",
                Ano = 2015
            };
            carro3.Imprimir();
        }
    }
}
