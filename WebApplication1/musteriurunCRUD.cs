using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class musteriurunCRUD
    {
        db Db = new db();

        public bool kaydet(musteriUrun urun)
        {
            int cvp;
            bool cevap = true;
            Db.ac();

            SqlCommand cmd = new SqlCommand("insert into musteriurun values(@r,@a,@b,@c,@d)", Db.connection);
            cmd.Parameters.AddWithValue("@a", urun.No);
            cmd.Parameters.AddWithValue("@a", urun.Mno);
            cmd.Parameters.AddWithValue("@b", urun.Uno);
            cmd.Parameters.AddWithValue("@c", urun.Tarih);
            cmd.Parameters.AddWithValue("@d", urun.Miktar);
            cvp = cmd.ExecuteNonQuery();

            if (cvp == 0)
                return false;


            Db.kapat();
            return cevap;
        }

        public DataTable listele()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from musteriurun", Db.connection);
            Db.ac();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            Db.kapat();
            return dt;
        }
        public bool sil(int prm)
        {
            int cvp;
            bool cevap = true;
            Db.ac();
            SqlCommand cmd = new SqlCommand("delete from musteriurun where no=@no", Db.connection);
            cmd.Parameters.AddWithValue("@no", prm);
            
            cvp = cmd.ExecuteNonQuery();

            if (cvp == 0)
                return false;

            Db.kapat();

            return cevap;
        }

        public musteriUrun getir(int prm)
        {
            musteriUrun urun = new musteriUrun();
            DataTable dt = new DataTable();
            Db.ac();
            SqlCommand cmd = new SqlCommand("select * from musteriurun where no=@no", Db.connection);
            cmd.Parameters.AddWithValue("@no", prm);
            
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            adp.Fill(dt);

            urun.Mno = Convert.ToInt16(dt.Rows[0][0]);
            urun.Uno = Convert.ToInt16(dt.Rows[0][1]);
            urun.Tarih = Convert.ToDateTime(dt.Rows[0][2]);
            urun.Miktar = Convert.ToInt16(dt.Rows[0][3]);
            Db.kapat();

            return urun;
        }
        public bool guncelle(musteriUrun prm)
        {
            int ksay;
            bool cevap = true;

            Db.ac();
            SqlCommand komut = new SqlCommand("update urun set uadi=@b, fiyat=@c,miktar=@d  where uno=@a", Db.connection);
            komut.Parameters.AddWithValue("@a", prm.Mno);
            komut.Parameters.AddWithValue("@b", prm.Uno);
            komut.Parameters.AddWithValue("@c", prm.Tarih);
            komut.Parameters.AddWithValue("@d", prm.Miktar);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = false;
            }

            Db.kapat();
            return cevap;
        }
    }
}