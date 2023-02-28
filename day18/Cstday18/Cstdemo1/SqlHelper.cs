using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Cstdemo1
{
    public class SqlHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        }
    }
}