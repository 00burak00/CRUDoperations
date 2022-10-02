using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.AutoPostBack = true;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();

            if (DropDownList1.SelectedValue == "1")
            {
                DropDownList2.Items.Add("Seçim yapınız");
                DropDownList2.Items.Add("Ürün Ekle");
                DropDownList2.Items.Add("Ürün Listele");
            }
            else if (DropDownList1.SelectedValue == "2")
            {
                DropDownList2.Items.Add("Seçim yapınız");
                DropDownList2.Items.Add("Musteri Ekle");
                DropDownList2.Items.Add("Müsteri Listele");
            }
            else if (DropDownList1.SelectedValue == "3")
            {
                DropDownList2.Items.Add("Seçim yapınız");
                DropDownList2.Items.Add("Sepete Ekle");
                DropDownList2.Items.Add("Sepete Listele");
            }

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedIndex == 1)
                Response.Redirect("urunKaydet.aspx");
            else if (DropDownList2.SelectedIndex == 2)
                Response.Redirect("urunListele.aspx");
                

        }
    }
}