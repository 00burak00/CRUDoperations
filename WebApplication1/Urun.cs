using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Urun
    {
        int uno ;
        string uadi;
        double fiyat;
        int adet;

        public int Uno { get => uno; set => uno = value; }
       
        public string Uadi { get => uadi; set => uadi = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public int Adet { get => adet; set => adet = value; }
    }
}