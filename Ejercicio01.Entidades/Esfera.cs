namespace Ejercicio01.Entidades
{
    public class Esfera
    {
        private int _radio { get; }

        public double GetRadio() => _radio;

        public double GetDiametro() => 2 * GetRadio();

        public Esfera(int radio)
        {
            if (radio <= 0)
            {
                throw new ArgumentException("Joder, datos no validos");
            }
            _radio = radio;
        }

        public double GetArea() => 4 * Math.PI * Math.Pow(GetRadio(), 2);

        public double GetVolumen() => (4.0 / 3.0) * Math.PI * Math.Pow(GetRadio(), 3);

        public string GetInfo()
        {
            string message =
                $"\nDatos de la esfera \n " +
                $"\t Radio = {GetRadio()}\n" +
                $"\t Diametro = {GetDiametro()}\n" +
                $"\t Area = {GetArea()}\n" +
                $"\t Volumen = {GetVolumen()}\n";
            return message;
        }
    }
}
