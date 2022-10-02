using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class urunCRUD
    {
        db Db = new db();

        public bool kaydet(Urun urun)
        {
            int cvp;
            bool cevap = true;
            Db.ac();

            SqlCommand cmd = new SqlCommand("insert into urun values(@a,@b,@c,@d)", Db.connection);
            cmd.Parameters.AddWithValue("@a", urun.Uno);
            cmd.Parameters.AddWithValue("@b", urun.Uadi);
            cmd.Parameters.AddWithValue("@c", urun.Fiyat);
            cmd.Parameters.AddWithValue("@d", urun.Adet);
            cvp = cmd.ExecuteNonQuery();

            if (cvp == 0)
                return false;


            Db.kapat();
            return cevap;
        }

        public DataTable listele()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from urun", Db.connection);
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
            SqlCommand cmd = new SqlCommand("delete from urun where uno = @uno", Db.connection);
            cmd.Parameters.AddWithValue("@uno", prm);
            cvp = cmd.ExecuteNonQuery();

            if (cvp == 0)
                return false;

            Db.kapat();

            return cevap;
        }

        public Urun getir(int prm)
        {
            Urun urun = new Urun();
            DataTable dt = new DataTable();
            Db.ac();
            SqlCommand cmd = new SqlCommand("select * from urun where uno=@uno", Db.connection);
            cmd.Parameters.AddWithValue("@uno", prm);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            adp.Fill(dt);

            urun.Uno = Convert.ToInt16(dt.Rows[0][0]);
            urun.Uadi = Convert.ToString(dt.Rows[0][1]);
            urun.Fiyat = Convert.ToDouble(dt.Rows[0][2]);
            urun.Adet = Convert.ToInt16(dt.Rows[0][3]);
            Db.kapat();

            return urun;
        }
        public bool guncelle(Urun prm)
        {
            int ksay;
            bool cevap = true;

            Db.ac();
            SqlCommand komut = new SqlCommand("update urun set uadi=@b, fiyat=@c,miktar=@d  where uno=@a", Db.connection);
            komut.Parameters.AddWithValue("@a", prm.Uno);
            komut.Parameters.AddWithValue("@b", prm.Uadi);
            komut.Parameters.AddWithValue("@c", prm.Fiyat);
            komut.Parameters.AddWithValue("@d", prm.Adet);
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
