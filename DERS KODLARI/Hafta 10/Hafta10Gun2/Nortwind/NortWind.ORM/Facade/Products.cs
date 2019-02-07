using NortWind.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortWind.ORM.Facade
{
    public class Products
    {
        #region Select
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("listProducts", Tools._baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        #endregion
        #region INSERT
        public static bool Insert(Product p)
        {
            SqlCommand command = new SqlCommand("insertProduct",Tools._baglanti);
            //Adapter icine atılan sorguyu,trigger,stored procedureları çalıştımamızı sağlamaktadır.
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@prodName",p.ProductName);
            command.Parameters.AddWithValue("@unitPrice", p.UnitPrice);
            command.Parameters.AddWithValue("@unitsInStock", p.UnitsInStock);
            command.Parameters.AddWithValue("@CategoryID", p.CategoryID);
            command.Parameters.AddWithValue("@SupplierID",p.SupplierID);

            return Tools.ExecuteNonQuery(command); // Çalışması için veri tabanını open yapmamız gerekiyor
        }
        #endregion

    }
}
