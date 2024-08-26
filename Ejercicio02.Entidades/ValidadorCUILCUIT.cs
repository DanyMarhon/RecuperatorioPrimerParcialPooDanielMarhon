using RecuperatorioPrimerParcialPooTema1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio02.Entidades
{
    public static class ValidadorCUILCUIT
    {
        public static bool Validar(string cuilCuit, string tipo)
        {
            if (!Regex.IsMatch(cuilCuit, @"^\d{2}-\d{8}-\d{1}$"))
            {
                ConsoleExtensions.ShowMessage("Formato inválido.");
                return false;
            }

            string[] partes = cuilCuit.Split('-');
            int tipoCUIT = int.Parse(partes[0]);
            string dni = partes[1];
            int digitoVerificador = int.Parse(partes[2]);

            if (!EsTipoValido(tipoCUIT, tipo))
            {
                ConsoleExtensions.ShowMessage("El tipo no coincide con el CUIL/CUIT proporcionado.");
                return false;
            }

            if (digitoVerificador != CalcularDigitoVerificador(tipoCUIT, dni))
            {
                ConsoleExtensions.ShowMessage("Dígito verificador inválido.");
                return false;
            }
            return true;
        }

        private static bool EsTipoValido(int tipoCUIT, string tipo)
        {
            switch (tipo.ToLower())
            {
                case "hombre":
                    return tipoCUIT == 20;
                case "mujer":
                    return tipoCUIT == 27;
                case "empresa":
                    return tipoCUIT == 30;
                default:
                    return false;
            }
        }

        private static int CalcularDigitoVerificador(int tipoCUIT, string dni)
        {
            string cuilCuitSinDV = tipoCUIT + dni;
            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;

            for (int i = 0; i < multiplicadores.Length; i++)
            {
                suma += int.Parse(cuilCuitSinDV[i].ToString()) * multiplicadores[i];
            }

            int modulo = suma % 11;
            int digitoVerificador = 11 - modulo;

            if (digitoVerificador == 11) return 0;
            if (digitoVerificador == 10) return 9;
            return digitoVerificador;
        }
    }
}
