using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtopartAutomationSystem
{
    internal class SqlConnectionClass
    {
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-M8JLN9L\\SQLEXPRESS;Initial Catalog=carPark;Integrated Security=True");
            connection.Open();
            return connection;
        }    
    }
}
