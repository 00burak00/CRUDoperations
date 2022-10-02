using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class db
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R3N1TU3\\SQLEXPRESS;Initial Catalog=sepet_vt;Integrated Security=True");
        public void ac()
        {
            connection.Open();         
        }
        public void kapat()
        {
            connection.Close();
        }
    }
}