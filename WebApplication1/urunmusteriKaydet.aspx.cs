using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
TextBox3.Text = DateTime.Now.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            musteriurunCRUD musteriurun = new musteriurunCRUD();
            bool cvp;
            musteriUrun urun = new musteriUrun();
            urun.No = Convert.ToInt32( TextBox5.Text);
            urun.Mno = Convert.ToInt16(TextBox1.Text);
            urun.Uno = Convert.ToInt16(TextBox2.Text);
            urun.Tarih = DateTime.Now;
            
            urun.Miktar = Convert.ToInt32(TextBox4.Text);
            cvp = musteriurun.kaydet(urun);

            if (cvp)
                Label5.Text = "Başarılı";
            else
                Label5.Text = "Başarısız";
        }
    }
}