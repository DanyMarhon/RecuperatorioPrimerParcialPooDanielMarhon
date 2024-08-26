using Ejercicio03.Entidades;
using RecuperatorioPrimerParcialPooTema1;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kilo kilo = new Kilo(10);
            Libra libra = new Libra(20);

            Console.WriteLine($"Peso en Kilos: {kilo.GetPeso()} kg");
            Console.WriteLine($"Peso en Libras: {libra.GetPeso()} lb");

            Libra convertidaALibra = (Libra)kilo;
            Kilo convertidaAKilo = (Kilo)libra;
            Console.WriteLine($"Kilos a Libras: {convertidaALibra.GetPeso()} lb");
            Console.WriteLine($"Libras a Kilos: {convertidaAKilo.GetPeso()} kg");

            Kilo sumaEnKilos = kilo + libra;
            Libra sumaEnLibras = libra + kilo;
            Console.WriteLine($"Suma en Kilos: {sumaEnKilos.GetPeso()} kg");
            Console.WriteLine($"Suma en Libras: {sumaEnLibras.GetPeso()} lb");

            bool sonIguales = kilo == (Kilo)libra;
            Console.WriteLine($"¿Son iguales los pesos? {sonIguales}");

            Console.WriteLine(
                kilo == convertidaAKilo
                ? "Los pesos en Kilos son iguales."
                : "Los pesos en Kilos no son iguales.");
            Console.WriteLine(
                libra == convertidaALibra
                ? "Los pesos en Libras son iguales."
                : "Los pesos en Libras no son iguales.");

            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
