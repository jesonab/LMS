using System;
namespace LMS.Model
{
    /// <summary>
    /// S_Customer:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class S_Customer
    {
        public S_Customer()
        { }
        #region Model
        private int _s_custono;
        private string _s_custotel;
        private string _s_custoname;
        /// <summary>
        /// 
        /// </summary>
        public int S_CustoNo
        {
            set { _s_custono = value; }
            get { return _s_custono; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S_CustoTel
        {
            set { _s_custotel = value; }
            get { return _s_custotel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S_CustoName
        {
            set { _s_custoname = value; }
            get { return _s_custoname; }
        }
        #endregion Model

    }
}

