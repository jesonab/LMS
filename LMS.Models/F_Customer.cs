using System;
namespace LMS.Model
{
    /// <summary>
    /// F_Customer:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class F_Customer
    {
        public F_Customer()
        { }
        #region Model
        private int _f_custono;
        private string _f_custotel;
        private string _f_custoname;
        /// <summary>
        /// 
        /// </summary>
        public int F_CustoNo
        {
            set { _f_custono = value; }
            get { return _f_custono; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string F_CustoTel
        {
            set { _f_custotel = value; }
            get { return _f_custotel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string F_CustoName
        {
            set { _f_custoname = value; }
            get { return _f_custoname; }
        }
        #endregion Model

    }
}

