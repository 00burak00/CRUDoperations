using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class urunListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

                urunCRUD urunCRUD = new urunCRUD();
                db Db = new db();
                DataTable dataTable = new DataTable();
                dataTable = urunCRUD.listele();

                if (Request.QueryString["prm"] == null)
                {

                    liste.InnerHtml = "<table>";
                    liste.InnerHtml += "<tr>  <td>Ürün No</td>  <td>Ürün Adı</td>  <td>Fiyat</td>  <td>Miktar</td>    <td> Sil</td>  <td>Güncelle</td>  </tr>";
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        liste.InnerHtml += "<tr>  <td>" + dataTable.Rows[i][0] + "</td>  <td>" + dataTable.Rows[i][1] + "</td>  <td>" + dataTable.Rows[i][2] + "</td>  <td>" + dataTable.Rows[i][3] + "</td>    <td><a href='urunListele.aspx?prm=" + dataTable.Rows[i][0] + "'>Sil</a> </td>   <td><a href='urunGuncelle.aspx?prm=" + dataTable.Rows[i][0] + "'>Güncelle</a> </td>   </tr>";
                    }
                    liste.InnerHtml += "</table>";
                }
                else
                { 
                    bool cvp = urunCRUD.sil(Convert.ToInt32(Request.QueryString["prm"]));
                    if (cvp)
                        liste.InnerHtml += "<label>Başarılı</label>";
                    else
                        liste.InnerHtml += "<label>Başarılı</label>";
                }



            }
        }
    }
