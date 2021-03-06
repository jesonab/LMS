﻿using System;
namespace LMS.Model
{
    /// <summary>
    /// Order:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Order
    {
        public Order()
        { }
        #region Model
        private int _orderid;
        private DateTime _ordertime;
        private string _address;
        private int _ordernum;
        private decimal _ordermoney;
        private string _s_custoname;
        private string _f_custoname;
        private string _goodsname;
        private string _start;
        private string _end;
        private string _path;
        /// <summary>
        /// 
        /// </summary>
        public int OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Car CarID
        {  set ;  get ;  }
        /// <summary>
        /// 
        /// </summary>
        public Class ClassID
        { set ; get; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OrderTime
        {
            set { _ordertime = value; }
            get { return _ordertime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int OrderNum
        {
            set { _ordernum = value; }
            get { return _ordernum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal OrderMoney
        {
            set { _ordermoney = value; }
            get { return _ordermoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public S_Customer S_CustoNo
        { set ; get ;  }
        /// <summary>
        /// 
        /// </summary>
        public string S_CustoName
        {
            set { _s_custoname = value; }
            get { return _s_custoname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public F_Customer F_CustoNo
        { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public string F_CustoName
        {
            set { _f_custoname = value; }
            get { return _f_custoname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GoodsName
        {
            set { _goodsname = value; }
            get { return _goodsname; }
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
        public string Path
        {
            set { _path = value; }
            get { return _path; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Admin AdminNo
        {set ; get ; }
        /// <summary>
        /// 
        /// </summary>
        public line LineID
        { set; get; }
        #endregion Model

    }
}

