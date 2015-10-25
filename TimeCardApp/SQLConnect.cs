using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCardApp
{
    class SqlConnect
    {
        SqlConnection testConn = new SqlConnection("user id=Inuyasha-PC\\Inuyasha;password=thexfiles1!;server=INUYASHA-PC\\SQLEXPRESS;Trusted_Connection=yes;database=Work Database;connection timeout=30");

        public SqlConnection SqlConnector()
        {
//        private String msg;
            testConn.Open();
            return testConn;
        }

        public SqlConnection SqlClose()
        {
            testConn.Close();
            return testConn;
        }

//        try
//        {
//            testConn.Open();
//            msg = new SqlCommand("select * from Table", testConn).ToString();
//        }
//        catch (Exception)
//        {
//                
//            msg = "Connection to SQL Server Failed";
//        }
    }
}
