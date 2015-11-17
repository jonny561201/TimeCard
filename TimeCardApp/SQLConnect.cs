using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCardApp   
{
    class SqlConnect : ISQLInterface
    {
        SqlConnection testConn = new SqlConnection("user id=Inuyasha-PC\\Inuyasha;pwd=thexfiles1!;server=INUYASHA-PC\\SQLEXPRESS;Trusted_Connection=yes;database=Work Database;connect timeout=30");
//        SqlCommand testCommand = new SqlCommand();

        public SqlConnection SqlConnector()
        {
            testConn.Open();
            return testConn;
        }

        public SqlConnection SqlClose()
        {
            testConn.Close();
            return testConn;
        }

        public void WriteTable(String InsertValue)
        {
            SqlCommand writeCmd = new SqlCommand();
            writeCmd.Connection = testConn;
            writeCmd.CommandText = InsertValue;
            writeCmd.ExecuteNonQuery();
        }

        public Dictionary<String, String> ReadTable(String ReadValue)
        {
            SqlCommand ReadCmd = new SqlCommand("select * from TIME_CARD where Start_Date = " + ReadValue, testConn);
            Dictionary<String, String> databaseCollectiDictionary = new Dictionary<string, string>();
//            ReadCmd.CommandText = ReadValue;
//            ReadCmd.Connection = testConn;
            SqlDataReader MyReader = ReadCmd.ExecuteReader();

            while (MyReader.Read())
            {
                databaseCollectiDictionary.Add(MyReader["Start_Date"].ToString(), MyReader["End_Date"].ToString());
            }

            return databaseCollectiDictionary;
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
