using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            musteriCRUD musteriCruD = new musteriCRUD();
            db Db = new db();
            DataTable dataTable = new DataTable();
            dataTable = musteriCruD.listele();

            if (Request.QueryString["prm"]==null)
            {
            
                liste.InnerHtml = "<table>";
                liste.InnerHtml += "<tr>  <td>Müşteri No</td>  <td>Ad</td>  <td>Soyad</td>  <td>Doğum Tarihi</td>  <td>TC No</td>  <td> Sil</td>  <td>Güncelle</td>  <td></td> </tr>";
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    liste.InnerHtml += "<tr>  <td>" + dataTable.Rows[i][0] +"</td>  <td>" + dataTable.Rows[i][1] +"</td>  <td>" + dataTable.Rows[i][2] +"</td>  <td>" + dataTable.Rows[i][3] +"</td>  <td>" + dataTable.Rows[i][4] +"</td>  <td><a href='ListeleMusteri.aspx?prm="+ dataTable.Rows[i][0] +"'>Sil</a> </td>   <td><a href='musteriGuncelle.aspx?prm="+ dataTable.Rows[i][0] +"'>Güncelle</a> </td>   </tr>";
                }
                liste.InnerHtml += "</table>";
                }
            else
            {
                
                bool cvp = musteriCruD.sil(Convert.ToInt32(Request.QueryString["prm"]));
                if(cvp) 
                liste.InnerHtml += "</table> <label >Başarılı</label><br>";
                else
                liste.InnerHtml += "</table> <label >Başarısız</label><br>";
                    
            }
                
        }
            


    }

       
}
