namespace Ejercicio03.Entidades
{
    public class Kilo
    {
        private float peso;

        public float GetPeso() => peso;

        public Kilo(float peso = 5f)
        {
            this.peso = peso;
        }

        public static implicit operator float(Kilo kilo)
        {
            return kilo.peso;
        }

        public static bool operator ==(Kilo k1, Kilo k2)
        {
            return k1.peso == k2.peso;
        }

        public static bool operator !=(Kilo k1, Kilo k2)
        {
            return !(k1 == k2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Kilo kilo)) return false;
            return this.Equals(kilo);
        }
        public override int GetHashCode()
        {
            return this.peso.GetHashCode();
        }

        public static explicit operator Kilo(float peso)
        {
            return new Kilo(peso);
        }

        public static explicit operator Libra(Kilo kilo)
        {
            return new Libra(kilo.peso * 2.20462262f);
        }

        public static Kilo operator +(Kilo k1, Libra l1)
        {
            return new Kilo(k1.peso + (float)l1);
        }

        public static bool operator ==(Kilo k, Libra l)
        {
            return k == (Kilo)l;
        }

        public static bool operator !=(Kilo k, Libra l)
        {
            return !(k == (Kilo)l);
        }

        public static Kilo operator +(Kilo k1, Kilo k2)
        {
            return new Kilo(k1.peso + k2.peso);
        }
    }
}
