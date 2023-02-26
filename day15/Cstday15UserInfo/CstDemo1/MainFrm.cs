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

namespace CstDemo1
{
    public partial class MainFrm : Form
    {
        //declare varable to save selected rowID

        private int updateUserID = 0;

        public MainFrm()
        {
            InitializeComponent();
        }

       
        /// <summary> load all user data to griddataview
       
        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadUserInfos();
        }

        #region loadUserInfos
        /// <summary>
        /// load all record from database with "DataAdapter"
        /// </summary>
        private void LoadUserInfos()
        {
            List<UserInfo> userList = new List<UserInfo>();
            //  MessageBox.Show("data loading!!");
            String connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            string sqlText = "Select * from dbo.userinfo where Delflag=0";

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlText,connStr))
            {
                // read data from database, fill

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                // not common, never recommend
                //this.dgvUserInfo.DataSource = dt;

                foreach (DataRow dataRow in dt.Rows)
                {
                    UserInfo userInfo = new UserInfo();
                    userInfo.UserID = int.Parse(dataRow["UserID"].ToString());
                    userInfo.UserName = dataRow["UserName"].ToString();
                    userInfo.UserAge = int.Parse(dataRow["UserAge"].ToString());
                    userInfo.UserEmail = dataRow["UserEmail"].ToString();
                    userInfo.UserMobile = dataRow["UserMobile"].ToString();
                    userInfo.DelFlag = short.Parse(dataRow["DelFlag"].ToString());
                    userList.Add(userInfo);

                }

                this.dgvUserInfo.DataSource = userList;
            }
        }
        #endregion
        #region delete one record by userid-ExecuteNonQuery
        private void btnDelete_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("data deleted!");

            if (this.dgvUserInfo.SelectedRows.Count <= 0)
            {
                MessageBox.Show("please select at least one row");
            }

            int deleteUserID = int.Parse(this.dgvUserInfo.SelectedRows[0].Cells["UserID"].Value.ToString());
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //cmd.CommandText = "delete from userinfo where UserID=@UserID";
                    cmd.CommandText = "UPDATE dbo.userInfo SET Delflag=1 WHERE UserID=@UserID";
                    cmd.Parameters.AddWithValue("@UserID", deleteUserID);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("record deleted successfully!");
                    }

                    // after deleted record, reload userinfo

                    LoadUserInfos();
                }
            }
        }
        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserInfoAddFrm useraddFrm = new UserInfoAddFrm();
            //UserAddFrm = new UserInfoAddFrm();
          


            useraddFrm.Show();

            
            
        }
        #region read one record from database by selectedID
        /// <summary>
        /// read one record from database by selectedID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserInfo_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("data selected!");

            //check if rows is selected.
            if (this.dgvUserInfo.SelectedRows.Count <= 0)
            {
                return;
            }
            //MessageBox.Show(this.dgvUserInfo.SelectedRows[0].Cells[0].Value.ToString());

            int selectRowID=int.Parse(this.dgvUserInfo.SelectedRows[0].Cells[0].Value.ToString());
            updateUserID = selectRowID;

            // open database, get userinfo by selectRowID

            String connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "select UserName,UserAge,UserEmail,UserMobile from UserInfo where UserID=@UserID";
                    cmd.Parameters.AddWithValue("@UserID", selectRowID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            this.txtUserName.Text = reader["UserName"].ToString();
                            this.txtUserAge.Text = reader["UserAge"].ToString();
                            this.txtUseremail.Text = reader["UserEmail"].ToString();
                            this.txtUserMobile.Text = reader["UserMobile"].ToString();

                        }

                    }

                }
            }

            #endregion

        }
        #region save record to database
        private void btnSave_Click(object sender, EventArgs e)
        {
            // save update record to database
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "update UserInfo set UserName=@UserName,UserAge=@UserAge,UserEmail=@UserEmail,UserMobile=@UserMobile where UserID=@UserID";
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@UserAge", txtUserAge.Text);
                    cmd.Parameters.AddWithValue("@UserEmail", txtUseremail.Text);
                    cmd.Parameters.AddWithValue("@UserMobile", txtUserMobile.Text);
                    cmd.Parameters.AddWithValue("@UserID", updateUserID);
                    int nums=cmd.ExecuteNonQuery();

                    if (nums > 0)
                    {
                        MessageBox.Show("record saved success");
                    }else
                    {
                        MessageBox.Show("record saved failure");
                    }

                }
            }
            LoadUserInfos();//refresh record after update
        }

        #endregion
        #region multiple condition search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // creat one static method for sql connection string

            String connStr = SqlHelper.GetSqlConnectionString();
            // dataAdapter read record

            String sqlTxt = "select * from UserInfo";

            List<string> whereList = new List<string>();// declare whereList
            List<SqlParameter> parameters = new List<SqlParameter>(); //declare paramers list

            if (!string.IsNullOrEmpty(this.txtSearchUserName.Text.Trim()))
            {
                // add condition userName to whereList

                whereList.Add(" UserName Like @UserName ");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserName";
                parameter.Value = "%"+txtSearchUserName.Text+"%";
                parameters.Add(parameter);


            }
            // second condition--userEmail
            if (!string.IsNullOrEmpty(this.txtSearchUserEmail.Text.Trim()))
            {
                whereList.Add(" UserEmail like @UserEmail ");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserEmail";
                parameter.Value = "%" + txtSearchUserEmail.Text + "%";
                parameters.Add(parameter);

            }

            // third condition--userMobile

            if (!string.IsNullOrEmpty(this.txtSearchUserMobile.Text.Trim()))
            {
                whereList.Add(" UserMobile like @UserMobile");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserMobile";
                parameter.Value = "%" + txtSearchUserMobile.Text + "%";
                parameters.Add(parameter);

            }

          

            if (whereList.Count > 0)
            {
                sqlTxt += " where " + string.Join(" and ", whereList);

            }

            List<UserInfo> userList = new List<UserInfo>();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlTxt,connStr))
            {
                adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());

                DataTable dt = new DataTable();
                adapter.Fill(dt);
               // this.dgvUserInfo.DataSource = dt;

                foreach (DataRow dataRow in dt.Rows)
                {
                    UserInfo userInfo = new UserInfo();

                    userInfo.UserID = int.Parse(dataRow["UserID"].ToString());
                    userInfo.UserName = dataRow["UserName"].ToString();
                    userInfo.UserMobile = dataRow["UserMobile"].ToString();
                    userInfo.UserEmail = dataRow["UserEmail"].ToString();
                    userInfo.UserAge = int.Parse(dataRow["UserAge"].ToString());
                    userInfo.DelFlag = short.Parse(dataRow["DelFlag"].ToString());

                    userList.Add(userInfo);

                } // end of foreach

                this.dgvUserInfo.DataSource = userList;
            }




        }
        #endregion

        
    }

    





}
