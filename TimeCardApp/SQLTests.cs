using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TimeCardApp
{
    class SQLTests
    {
        [TestFixture]
        private class SQLConnectTests
        {
            SqlConnect connection = new SqlConnect();

            [Test]
            public void CreateSqlConnection()
            {
                String openState = connection.SqlConnector().State.ToString();
                Assert.AreEqual(openState, "Open");
                connection.SqlClose();
            }

            [Test]
            public void CloseConnection()
            {
                connection.SqlConnector();
                connection.SqlClose();
                String closeState = connection.SqlClose().State.ToString();
                Assert.AreEqual(closeState,"Closed");
            }

//            [Test]
//            public void WriteToTable()
//            {
//                connection.SqlConnector();
//                String InsertValue = "INSERT INTO TIME_CARD(Start_Date, End_Date) Values ('2015-02-15 01:55:00.000', '2015-02-16 01:50:00.000')";
//                connection.WriteTable(InsertValue);
//                connection.SqlClose();
//            }

            [Test]
            public void ReadFromTable()
            {
                connection.SqlConnector();
                String ReadValue = "'2002-09-24 01:00:00.000'";
                connection.ReadTable(ReadValue);
                connection.SqlClose();
            }
        }
    }
}
