using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class musteriCRUD
    {
        db Db=new db();
        
        public bool kaydet(Musteri musteri)
        {
            int cvp;
            bool cevap=true;
            Db.ac();

            SqlCommand cmd = new SqlCommand("insert into musteri values(@a,@b,@c,@d,@e)", Db.connection);
            cmd.Parameters.AddWithValue("@a", musteri.Mno);
            cmd.Parameters.AddWithValue("@b", musteri.Ad);
            cmd.Parameters.AddWithValue("@c", musteri.Soyad);
            cmd.Parameters.AddWithValue("@d", musteri.Dtarih);
            cmd.Parameters.AddWithValue("@e", musteri.Tc);
            cvp=cmd.ExecuteNonQuery();

            if(cvp == 0)
                return false;
                

            Db.kapat();
            return cevap;
        }

        public DataTable listele()
        {
            
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from musteri", Db.connection);
            Db.ac();
            SqlDataAdapter adp=new SqlDataAdapter(cmd);
            adp.Fill(dt);

            Db.kapat();
            return dt;
        }
        public bool sil(int prm)
        {
            int cvp;
            bool cevap = true;
            Db.ac();
            SqlCommand cmd = new SqlCommand("delete from musteri where mno = @mno", Db.connection);
            cmd.Parameters.AddWithValue("@mno", prm);
            cvp = cmd.ExecuteNonQuery();

            if (cvp == 0)
                return false;

            Db.kapat();

            return cevap;
        }

        public Musteri getir(int prm)
        {
            Musteri musteri = new Musteri();
            DataTable dt = new DataTable();
            Db.ac();
            SqlCommand cmd = new SqlCommand("select * from musteri where mno=@mno", Db.connection);
            cmd.Parameters.AddWithValue("@mno", prm);
            SqlDataAdapter adp= new SqlDataAdapter(cmd);

            

            adp.Fill(dt);
            
            musteri.Mno = Convert.ToInt32(dt.Rows[0][0]);
            musteri.Ad = Convert.ToString(dt.Rows[0][1]);
            musteri.Soyad = Convert.ToString(dt.Rows[0][2]);
            musteri.Dtarih = Convert.ToDateTime(dt.Rows[0][3]);
            musteri.Tc = Convert.ToString(dt.Rows[0][4]);
            Db.kapat();
            
            return musteri;
        }
        public bool guncelle(Musteri prm)
        {
            int ksay;
            bool cevap = true;
            
            Db.ac();
            SqlCommand komut = new SqlCommand("update Musteri set ad=@b, soyad=@c, dtarih=@d, tc=@e where mno=@a", Db.connection);
            komut.Parameters.AddWithValue("@a", prm.Mno);
            komut.Parameters.AddWithValue("@b", prm.Ad);
            komut.Parameters.AddWithValue("@c", prm.Soyad);
            komut.Parameters.AddWithValue("@d", prm.Dtarih);
            komut.Parameters.AddWithValue("@e", prm.Tc);
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