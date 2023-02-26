using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo1
{
    class UserInfo
    {
        public int UserID { get; set; }
        public String UserName { get; set; }
        public String UserEmail { get; set; }
        public int UserAge { get; set; }
        public String UserMobile { get; set; }
        public int DelFlag { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime LastErrDateTime { get; set; }

    }
}
