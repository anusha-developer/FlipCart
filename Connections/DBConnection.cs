using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FlipCart.Connections
{
    public class DBConnection
    {
        public  static SqlConnection CreateConnection()
        {
            //Sql Connection used in database
            //Sqlconnection is a class
            //Con is a object
            //datasource is a connection that connected to the database in that we give server name (or).
            //database is database name
            //integrated security(SSPI)Security Support Provider Interface---it used for security  purpose
            SqlConnection con = new SqlConnection("data source=.; database=Filpcart; integrated security=SSPI");
            return con;
        }
    }
}