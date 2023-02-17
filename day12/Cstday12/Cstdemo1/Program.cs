using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

namespace Cstdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=HERO;uid=sa;pwd=cst001.com;database=market";
            // server database server ip Address
            // uid database username
            // pwd database password
            //database

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open(); // open database
            Console.WriteLine("database was opened");
            Thread.Sleep(2000);
            //Console.ReadKey();
            conn.Close();
            Console.WriteLine("database was closed");

        }
    }
}
