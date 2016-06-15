using System;
namespace LMS.Model
{
    /// <summary>
    /// Line:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class line
    {
        public line()
        { }
        #region Model
        private int _lineid;
        private int _linelength;
        private string _start;
        private string _line;
        private string _end;
        /// <summary>
        /// 
        /// </summary>
        public int LineID
        {
            set { _lineid = value; }
            get { return _lineid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int LineLength
        {
            set { _linelength = value; }
            get { return _linelength; }
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
        public string Line
        {
            set { _line = value; }
            get { return _line; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string End
        {
            set { _end = value; }
            get { return _end; }
        }
        #endregion Model

    }
}

