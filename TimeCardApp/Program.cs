using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCardApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String msg;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new Form1());
            SqlConnection testConn = new SqlConnection("Data Source=(Local);Initial Catalog=Table;Integrated Security=True");
            try
            {
                testConn.Open();
                msg = new SqlCommand("select * from Table", testConn).ToString();
            }
            catch (Exception)
            {
                
                msg = "Connection to SQL Server Failed";
            }
            

        }
    }
}
