using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class DBNorthWind
    {

        public DBNorthWind()
        {
        }

        public void Øvelse2a(string connectionString)
        {
            string queryString = "select AVG(orders.Freight) from orders";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IDataRecord record = (IDataRecord)reader;

                            Console.WriteLine(record[0]);
                        }
                    }
                }
            }    
        }
        public void Øvelse2b(string connectionString)
        {
            decimal sum = 0;
            int counter = 0;
            string queryString = "select orders.freight from orders";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IDataRecord record = (IDataRecord)reader;
                            sum += (decimal)record[0];
                            counter++;
                        }
                        Console.WriteLine(sum / counter);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
           var reader =  new DBNorthWind();
           reader.Øvelse2a(Properties.Settings1.Default.ConnString);
           reader.Øvelse2b(Properties.Settings1.Default.ConnString);
        }

    }
}