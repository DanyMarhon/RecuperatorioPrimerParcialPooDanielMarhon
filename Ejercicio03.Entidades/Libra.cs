using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03.Entidades
{
    public class Libra
    {
        private float peso;

        public float GetPeso() => peso;

        public Libra(float peso = 5f)
        {
            this.peso = peso;
        }

        public static implicit operator float(Libra libra)
        {
            return libra.peso;
        }

        public static bool operator ==(Libra l1, Libra l2)
        {
            return l1.peso == l2.peso;
        }

        public static bool operator !=(Libra l1, Libra l2)
        {
            return !(l1 == l2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Libra libra)) return false;
            return this.Equals(libra);
        }

        public override int GetHashCode()
        {
            return this.peso.GetHashCode();
        }

        public static explicit operator Libra(float peso)
        {
            return new Libra(peso);
        }

        public static explicit operator Kilo(Libra libra)
        {
            return new Kilo(libra.peso * 0.45359237f);
        }

        public static Libra operator +(Libra l1, Libra l2)
        {
            return new Libra(l1.peso + l2.peso);
        }

        public static bool operator ==(Libra l, Kilo k)
        {
            return l == (Libra)k;
        }

        public static bool operator !=(Libra l, Kilo k)
        {
            return !(l == (Libra)k);
        }

        public static Libra operator +(Libra l1, Kilo k1)
        {
            return new Libra(l1.peso + (float)k1);
        }
    }
}
