using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace testeP3.Control
{
    public class DataBase
    {
        public static SqlConnection cnn = new SqlConnection("Data Source=localhost; Initial Catalog=desafio_sql; Integrated Security=false; User ID=sa;Password=abc123##");

        public DataBase()
        {
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open !");
                cnn.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");
            }
        }
    }
}
