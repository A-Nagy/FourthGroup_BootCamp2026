using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Revision.ConnectDb
{
     class ConnectDatabase
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Server =DESKTOP-LRMPGLQ;Database=Group3;User Id =sa;Password=123";
            string Query = "insert into Students values(4,'Mashael',98)";
           
            using(SqlConnection con = new SqlConnection(ConnectionString)) 
            {
                 SqlCommand cmd     = new SqlCommand(Query, con);
                 con.Open();
                cmd.ExecuteNonQuery();
              //SqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read()) 
                //{
                //    int id = Convert.ToInt32(reader["Id"]);
                //    Console.WriteLine($"student Id is {reader["Id"]}  \nStudent Name is {reader["FullName"]}\nStudent Grade is {reader["Grade"]}");
                //}
                con.Close();
                //reader.Close();
            }

        }

    }
}
