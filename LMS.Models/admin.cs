using System;
namespace LMS.Model
{
    /// <summary>
    /// Admin:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Admin
    {
        public Admin()
        { }
        #region Model
        private int _adminno;
        private string _adminname;
        private string _adminaccount;
        private string _adminpwd;
        private string _admintel;
        private string _adminsex;
        /// <summary>
        /// 
        /// </summary>
        public int AdminNo
        {
            set { _adminno = value; }
            get { return _adminno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AdminName
        {
            set { _adminname = value; }
            get { return _adminname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AdminAccount
        {
            set { _adminaccount = value; }
            get { return _adminaccount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AdminPwd
        {
            set { _adminpwd = value; }
            get { return _adminpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AdminTel
        {
            set { _admintel = value; }
            get { return _admintel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AdminSex
        {
            set { _adminsex = value; }
            get { return _adminsex; }
        }
        #endregion Model

    }
}

