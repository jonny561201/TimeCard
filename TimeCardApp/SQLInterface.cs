using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCardApp
{
    interface ISQLInterface
    {
        SqlConnection SqlConnector();
        SqlConnection SqlClose();
        void WriteTable(String InsertValue);
        String ReadTable(String ReadValue);

    }
}
