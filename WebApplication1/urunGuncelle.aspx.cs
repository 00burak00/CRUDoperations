using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class urunGuncelle : System.Web.UI.Page
    {
        urunCRUD urunCRUD = new urunCRUD();
        protected void Page_Load(object sender, EventArgs e)
        {
            Urun urun = urunCRUD.getir(Convert.ToInt16(Request.QueryString["prm"]));
            if (!IsPostBack)
            {


                TextBox1.Text = urun.Uno.ToString();
                TextBox1.Enabled = false;
                TextBox2.Text = urun.Uadi;
                TextBox3.Text = Convert.ToString( urun.Fiyat);
                TextBox4.Text = urun.Adet.ToString();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool cvp;
            Urun yurun = new Urun();
            yurun.Uno = Convert.ToInt16(TextBox1.Text);
            yurun.Uadi = TextBox2.Text;
            yurun.Fiyat = Convert.ToDouble(TextBox3.Text);
            yurun.Adet = Convert.ToInt16(TextBox4.Text);
            
            cvp = urunCRUD.guncelle(yurun);
            if (cvp == true)
                Label5.Text = "Başarılı";
            else
                Label5.Text = "Başarısız";
        }
    }
}