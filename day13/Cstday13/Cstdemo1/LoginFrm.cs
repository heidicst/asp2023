using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Cstdemo1
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()) || string.IsNullOrEmpty(txtUserPWD.Text.Trim()))
            {
                MessageBox.Show("Username or Password is empty!");
            }

            // connect to database, retrieve user's crendentials
            // string connStr = "server=HERO;uid=sa;pwd=cst001.com;database=market";

            string connStr = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;

            using (SqlConnection conn=new SqlConnection(connStr))
            {

                using (SqlCommand cmd =conn.CreateCommand())
                {
                    conn.Open();
                   //cmd.CommandText = @"select count(*) from UserInfo where UserName= '" + txtUserName.Text + "' and UserPassword='"+ txtUserPWD.Text + "'";

                    /*
                          '"+txtUserName.Text"'
                          '"+txtPwd.Text"'

                     */

                    // method 2

                    String strSql = string.Format(@"Select count(*) from dbo.Userinfo where UserName='{0}' and UserPassword='{1}'",txtUserName.Text,txtUserPWD.Text);

                    cmd.CommandText = strSql;

                    object result=cmd.ExecuteScalar();
                    int rows=int.Parse(result.ToString());
                    if (rows >= 1)
                    {
                        MessageBox.Show("Login in Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("your username or password is invalid!!");
                    }

                }


            }

        }
    }
}
