using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace NortWind.ORM
{
    public class Tools
    {
        //1. Yol
        //ev--- SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True")
        //Okul --- SqlConnection baglanti = new SqlConnection("Data Source=SEM-BILGISAYAR\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True")
        //2. Yol
        //private staticSqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True")
        //public static SqlConnection Baglanti{ get { return baglanti; } }
        //3. Yol
        // UI projesinde App.Config icerisine baglanti parametresi eklenir
        // Bu yol Bir müşteriye gidildiğinde bir daha yukarıdaki bağlantı kısımlarını değiştirmemek için sadece App.config kısmında değişiklikle daha kolay ulaşılabilir olmaktadır.
        internal static SqlConnection _baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        internal static bool ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                int affected = command.ExecuteNonQuery();
                if (command.Connection.State != ConnectionState.Closed)
                {
                    command.Connection.Close();

                }
                return (affected > 0);
            }catch (Exception)
            {
                return false;
            }
            finally{
                if (command.Connection.State != ConnectionState.Closed)
                {
                    command.Connection.Close();
                }
            }
            
        }

        //internal static bool ExecuteNonQuery(SqlCommand command)
        //{

        //}
    }
}
