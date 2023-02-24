using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cstdemo1
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("data loding!!!");

            LoadUserInfo();
        }

        /// <summary>
        /// load all user data from database
        /// </summary>


        private void LoadUserInfo()
        {

            List<UserInfo> userList = new List<UserInfo>(); // delcare empty list-userlist

            String connStr = ConfigurationManager.ConnectionStrings["strSql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM userinfo WHERE Delflag=0";
                // read all data by data reader
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserInfo userInfo = new UserInfo();
                            userInfo.UserName = reader["UserName"].ToString();
                            userInfo.UserAge = int.Parse(reader["UserAge"].ToString());
                            userInfo.UserEmail = reader["UserEmail"].ToString();
                            userInfo.UserMobile = reader["UserMobile"].ToString();

                            userList.Add(userInfo);
                        }// end while loop
                    } // end datareader

                }// end Sqlcommand

            }// end connction

            this.dgvUserInfo.DataSource = userList;
        }
    }
}
