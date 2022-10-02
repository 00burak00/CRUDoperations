using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class urunmusteriGuncelle : System.Web.UI.Page
    {
        musteriurunCRUD musteriurunCRUD = new musteriurunCRUD();
        protected void Page_Load(object sender, EventArgs e)
        {
            musteriUrun urun = musteriurunCRUD.getir(Convert.ToInt16(Request.QueryString["prm"]));
            if (!IsPostBack)
            {

                TextBox5.Text = urun.No.ToString();
                TextBox1.Text = urun.Mno.ToString();
                TextBox2.Text = urun.Uno.ToString();
                TextBox3.Text = Convert.ToString(urun.Tarih);
                TextBox4.Text = urun.Miktar.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool cvp;
            musteriUrun yurun = new musteriUrun();
            yurun.Mno = Convert.ToInt16(TextBox1.Text);
            yurun.Uno = Convert.ToInt16(TextBox2.Text);
            yurun.Tarih = Convert.ToDateTime(TextBox3.Text);
            yurun.Miktar = Convert.ToInt16(TextBox4.Text);

            cvp = musteriurunCRUD.guncelle(yurun);
            if (cvp == true)
                Label5.Text = "Başarılı";
            else
                Label5.Text = "Başarısız";
        }
    }
}