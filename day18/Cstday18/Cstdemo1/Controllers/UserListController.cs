using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cstdemo1.Models;

namespace Cstdemo1.Controllers
{
    public class UserListController : Controller
    {
        // GET: UserList
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var _user = new UserInfo { UserID=10,UserMobile="6478333666",UserName="Heidi"};
            string testStr = "Welcome to Cst college!!";

            ViewData["abcStr"] = testStr;

            ViewBag.myName = "Cstcollege College instructor Heidi";
            TempData["cstName"] = "Hello Cstcollege!!";

            return View(_user);
        }



        public ActionResult Show()
        {
            string connStr = SqlHelper.GetConnectionString();
            string sqlTxt = "Select * from dbo.userinfo where DelFlag=0";

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlTxt,connStr))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ViewData["dt"] = dt;

            }
            
                return View();
        }
        public ActionResult Add()
        {
            return View();
        }
    }
}