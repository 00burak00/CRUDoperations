using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Guncelle : System.Web.UI.Page
    {
        musteriCRUD  musteriCRUD = new musteriCRUD();
        protected void Page_Load(object sender, EventArgs e)
        { 
            Musteri mstri = musteriCRUD.getir(Convert.ToInt16(Request.QueryString["prm"]));
            if(!IsPostBack)
            {
           

            TextBox1.Text = mstri.Mno.ToString();
            TextBox2.Text = mstri.Ad;
            TextBox3.Text = mstri.Soyad;
            TextBox4.Text = mstri.Dtarih.ToShortDateString();
            TextBox5.Text = mstri.Tc;
            }
            
            
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            bool cvp;
            Musteri ymusteri = new Musteri();
            ymusteri.Mno = Convert.ToInt16( TextBox1.Text);
            ymusteri.Ad = TextBox2.Text;
            ymusteri.Soyad = TextBox3.Text;
            ymusteri.Dtarih = Convert.ToDateTime( TextBox4.Text);
            ymusteri.Tc = TextBox5.Text;
            cvp = musteriCRUD.guncelle(ymusteri);
            if (cvp == true)
                Label6.Text = "Başarılı";
            else
                Label6.Text = "Başarısız";
        }
    }
}