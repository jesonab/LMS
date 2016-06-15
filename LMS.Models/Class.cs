using System;
namespace LMS.Model
{
    /// <summary>
    /// Class:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Class
    {
        public Class()
        { }
        #region Model
        private int _classid;
        private string _start;
        private string _end;
        private DateTime _classtime;
        private int _carid;
        /// <summary>
        /// 
        /// </summary>
        public int ClassID
        {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Start
        {
            set { _start = value; }
            get { return _start; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string End
        {
            set { _end = value; }
            get { return _end; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ClassTime
        {
            set { _classtime = value; }
            get { return _classtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CarID
        {
            set { _carid = value; }
            get { return _carid; }
        }
        #endregion Model

    }
}

