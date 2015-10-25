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
            public void SQLConnection()
            {
                String openState = connection.SqlConnector().State.ToString();
                Assert.AreEqual(openState, "Open");
            }

            [Test]
            public void CloseConnection()
            {
                connection.SqlConnector();
                String closeState = connection.SqlClose().State.ToString();
                Assert.AreEqual(closeState,"Closed");
            }

        }
    }
}
