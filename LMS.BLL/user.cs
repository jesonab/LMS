using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.DAL;

namespace LMS.BLL
{
    public class user
    {
        userDAL dal = new userDAL();
        public bool Login(string cardid, string pwd)
        {
            return dal.Login(cardid, pwd);
        }
    }
}
