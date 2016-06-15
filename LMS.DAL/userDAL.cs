using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
     public  class userDAL
    {
        public userDAL()
        { }

        public bool Login(string id,string pwd)
        {
            var Result = true;
            var sql = "select * from admin where id=@id and pwd=@pwd";
            DataSet ds = DbHelperSQL.Query(sql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Result = false;
            }
            return Result;
        }
    }
}
