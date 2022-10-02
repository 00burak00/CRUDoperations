using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class musteriUrun
    {
        int no, mno, uno, miktar;
        DateTime tarih;

        public int No { get => no; set => no = value; }
        public int Mno { get => mno; set => mno = value; }
        public int Uno { get => uno; set => uno = value; }
        public int Miktar { get => miktar; set => miktar = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
    }
}