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
    public class Categories
    {
        
        #region SelectIslemi
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("listCategories",Tools._baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        #endregion
        #region InsertIslemi

        public static bool Insert(Category c)
        {
            SqlCommand command = new SqlCommand("insertCategory", Tools._baglanti);
            //Adapter icine atılan sorguyu,trigger,stored procedureları çalıştımamızı sağlamaktadır.
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@catName", c.CategoryName);
            command.Parameters.AddWithValue("@catDesc", c.Description);
            //if (command.Connection.State != ConnectionState.Open)
            //{
            //    command.Connection.Open();
            //}
            //int affected = command.ExecuteNonQuery();
            //if (command.Connection.State != ConnectionState.Closed)
            //{
            //    command.Connection.Close();

            //}
            // return (affected > 0);
            return Tools.ExecuteNonQuery(command);
          
        }
        #endregion


    }
}
