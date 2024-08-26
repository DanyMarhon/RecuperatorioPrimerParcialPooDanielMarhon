using Ejercicio01.Entidades;
using RecuperatorioPrimerParcialPooTema1;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera(1);

            Console.WriteLine(esfera.GetInfo());

            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
