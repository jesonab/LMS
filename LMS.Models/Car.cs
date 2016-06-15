using System;
namespace LMS.Model
{
    /// <summary>
    /// Car:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Car
    {
        public Car()
        { }
        #region Model
        private int _carid;
        private string _carno;
        private string _cardiver;
        private string _caraddress;
        private string _cartype;
        /// <summary>
        /// 
        /// </summary>
        public int CarID
        {
            set { _carid = value; }
            get { return _carid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CarNo
        {
            set { _carno = value; }
            get { return _carno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CarDiver
        {
            set { _cardiver = value; }
            get { return _cardiver; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CarAddress
        {
            set { _caraddress = value; }
            get { return _caraddress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CarType
        {
            set { _cartype = value; }
            get { return _cartype; }
        }
        #endregion Model

    }
}

