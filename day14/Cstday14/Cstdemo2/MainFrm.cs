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

namespace Cstdemo2
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadUserInfos();
        }

        /// <summary>
        /// load userdata from database with dataAdapter
        /// </summary>
        private void LoadUserInfos()
        {
            //
            //MessageBox.Show("data loading!!");

            String connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    
                    string strSql = "select * From UserInfo where DelFlag=0 ";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(strSql,conn))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);
                        //this.dgvUserInfo.DataSource = dt;

                        List<Userinfo> userList = new List<Userinfo>();

                        Userinfo userinfo = new Userinfo();
                        // convert data to userinfo
                        foreach (DataRow dataRow in dt.Rows)
                        {
                            userinfo.UserID = int.Parse(dataRow["UserId"].ToString());
                            userinfo.UserName = dataRow["UserName"].ToString();
                            userinfo.UserEmail = dataRow["UserEmail"].ToString();
                            userinfo.UserMobile = dataRow["UserMobile"].ToString();
                            userList.Add(userinfo);
                        }

                        this.dgvUserInfo.DataSource = userList;


                    }



                }
            }

        }
    }
}
