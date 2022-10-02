using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Musteri
    {
        int mno;
        string ad, soyad, tc;
        DateTime dtarih;

        public int Mno { get => mno; set => mno = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Tc { get => tc; set => tc = value; }
        public DateTime Dtarih { get => dtarih; set => dtarih = value; }
    }
}