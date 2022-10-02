using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        musteriCRUD musteriCRUD = new musteriCRUD();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            bool cvp;
            Musteri musteri = new Musteri();
            musteri.Mno = Convert.ToInt32( TextBox1.Text);
            musteri.Ad = TextBox2.Text;
            musteri.Soyad = TextBox3.Text;
            musteri.Dtarih = Convert.ToDateTime( TextBox4.Text);
            musteri.Tc = TextBox5.Text;
            cvp = musteriCRUD.kaydet(musteri);

            if (cvp)
                Label6.Text = "Başarılı";
            else
                Label6.Text = "Başarısız";

        }
    }
}