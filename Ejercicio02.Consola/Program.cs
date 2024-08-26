
using Ejercicio02.Entidades;
using RecuperatorioPrimerParcialPooTema1;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string cuilCuit = ConsoleExtensions.ReadString("Escriba el CUIL/CUIT (formato XX-XXXXXXXX-X): ");
                string tipo = ConsoleExtensions.ReadString("Escriba el tipo (hombre, mujer, empresa): ");
                
                bool esValido = ValidadorCUILCUIT.Validar(cuilCuit, tipo);

                if (esValido)
                {
                    ConsoleExtensions.ShowMessage("El CUIL/CUIT es válido.");
                }
                else
                {
                    ConsoleExtensions.ShowMessage("El CUIL/CUIT es inválido.");
                }

                ConsoleExtensions.EsperarPresionDeTecla(" ");
            }
        }
    }
}
