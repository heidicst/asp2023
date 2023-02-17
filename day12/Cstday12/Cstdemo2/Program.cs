using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Cstdemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "uid=sa;pwd=cst001.com;server=HERO;database=market";
            SqlConnection conn = new SqlConnection(connStr);

            // new sql command object
            #region          
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // open database
                conn.Open();
                cmd.CommandText = "INSERT INTO [dbo].[customers]([customerContact], [customerCity], [customerBirthDay]) values('Bob','Missisauga','1980-01-01 00:00:00.000')";
                int nums = cmd.ExecuteNonQuery();
                if (nums != 0)
                {
                    Console.WriteLine("insert {0}\t records successfully", nums);
                }
            } // end of try

            catch
            {
                Console.WriteLine("something is wrong! open database failure,please check!");
            }
            finally
            {
                conn.Close();
            }

            #endregion
        }
    }
}
