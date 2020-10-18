using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P2_054
{
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            return a / b;
        }

        public int Kali(int a, int b)
        {
            return a * b;
        }

        public int Kurang(int a, int b)
        {
            return a - b;
        }

        public int Tambah(int a, int b)
        {
            return a + b;
        }

        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            Koordinat hasil = new Koordinat();
            hasil.X = a.X + b.X;
            hasil.Y = a.Y + b.Y;
            return hasil;
        }
    }
}
