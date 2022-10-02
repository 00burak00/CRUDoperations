using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class urunKaydet : System.Web.UI.Page
    {
        urunCRUD ucrud = new urunCRUD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool cvp;
            Urun urun = new Urun();
            urun.Uno =Convert.ToInt16( TextBox1.Text);
            urun.Uadi = TextBox2.Text;
            urun.Fiyat = Convert.ToDouble( TextBox3.Text);
            urun.Adet = Convert.ToInt32( TextBox4.Text);
            cvp = ucrud.kaydet(urun);

            if (cvp)
                Label5.Text = "Başarılı";
            else
                Label5.Text = "Başarısız";
        }
    }
}