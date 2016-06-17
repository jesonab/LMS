using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LMS.DAL
{
    /// <summary>
    /// 数据访问类:Admin
    /// </summary>
    public partial class AdminDAL
    {
        public AdminDAL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int AdminNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Admin");
            strSql.Append(" where AdminNo=SQL2012AdminNo");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012AdminNo", SqlDbType.Int,4)
            };
            parameters[0].Value = AdminNo;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 登录
        /// </summary>  
        public bool islogin(string name,string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Admin");
            strSql.Append("where name=name1 and pwd=pwd1");
            SqlParameter[] parameters =
            {
                new SqlParameter("name1",SqlDbType.VarChar,16),
                new SqlParameter("pwd1",SqlDbType.VarChar,16)
            };
            parameters[0].Value = name;
            parameters[1].Value = pwd;
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>   
        public int Add(LMS.Model.Admin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Admin(");
            strSql.Append("AdminName,AdminAccount,AdminPwd,AdminTel,AdminSex)");
            strSql.Append(" values (");
            strSql.Append("SQL2012AdminName,SQL2012AdminAccount,SQL2012AdminPwd,SQL2012AdminTel,SQL2012AdminSex)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012AdminName", SqlDbType.VarChar,10),
                    new SqlParameter("SQL2012AdminAccount", SqlDbType.VarChar,16),
                    new SqlParameter("SQL2012AdminPwd", SqlDbType.VarChar,16),
                    new SqlParameter("SQL2012AdminTel", SqlDbType.NVarChar,11),
                    new SqlParameter("SQL2012AdminSex", SqlDbType.VarChar,4)};
            parameters[0].Value = model.AdminName;
            parameters[1].Value = model.AdminAccount;
            parameters[2].Value = model.AdminPwd;
            parameters[3].Value = model.AdminTel;
            parameters[4].Value = model.AdminSex;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(LMS.Model.Admin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Admin set ");
            strSql.Append("AdminName=SQL2012AdminName,");
            strSql.Append("AdminAccount=SQL2012AdminAccount,");
            strSql.Append("AdminPwd=SQL2012AdminPwd,");
            strSql.Append("AdminTel=SQL2012AdminTel,");
            strSql.Append("AdminSex=SQL2012AdminSex");
            strSql.Append(" where AdminNo=SQL2012AdminNo");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012AdminName", SqlDbType.VarChar,10),
                    new SqlParameter("SQL2012AdminAccount", SqlDbType.VarChar,16),
                    new SqlParameter("SQL2012AdminPwd", SqlDbType.VarChar,16),
                    new SqlParameter("SQL2012AdminTel", SqlDbType.NVarChar,11),
                    new SqlParameter("SQL2012AdminSex", SqlDbType.VarChar,4),
                    new SqlParameter("SQL2012AdminNo", SqlDbType.Int,4)};
            parameters[0].Value = model.AdminName;
            parameters[1].Value = model.AdminAccount;
            parameters[2].Value = model.AdminPwd;
            parameters[3].Value = model.AdminTel;
            parameters[4].Value = model.AdminSex;
            parameters[5].Value = model.AdminNo;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int AdminNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Admin ");
            strSql.Append(" where AdminNo=SQL2012AdminNo");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012AdminNo", SqlDbType.Int,4)
            };
            parameters[0].Value = AdminNo;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string AdminNolist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Admin ");
            strSql.Append(" where AdminNo in (" + AdminNolist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public LMS.Model.Admin GetModel(int AdminNo)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 AdminNo,AdminName,AdminAccount,AdminPwd,AdminTel,AdminSex from Admin ");
            strSql.Append(" where AdminNo=SQL2012AdminNo");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012AdminNo", SqlDbType.Int,4)
            };
            parameters[0].Value = AdminNo;

            LMS.Model.Admin model = new LMS.Model.Admin();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public LMS.Model.Admin DataRowToModel(DataRow row)
        {
            LMS.Model.Admin model = new LMS.Model.Admin();
            if (row != null)
            {
                if (row["AdminNo"] != null && row["AdminNo"].ToString() != "")
                {
                    model.AdminNo = int.Parse(row["AdminNo"].ToString());
                }
                if (row["AdminName"] != null)
                {
                    model.AdminName = row["AdminName"].ToString();
                }
                if (row["AdminAccount"] != null)
                {
                    model.AdminAccount = row["AdminAccount"].ToString();
                }
                if (row["AdminPwd"] != null)
                {
                    model.AdminPwd = row["AdminPwd"].ToString();
                }
                if (row["AdminTel"] != null)
                {
                    model.AdminTel = row["AdminTel"].ToString();
                }
                if (row["AdminSex"] != null)
                {
                    model.AdminSex = row["AdminSex"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select AdminNo,AdminName,AdminAccount,AdminPwd,AdminTel,AdminSex ");
            strSql.Append(" FROM Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" AdminNo,AdminName,AdminAccount,AdminPwd,AdminTel,AdminSex ");
            strSql.Append(" FROM Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Admin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.AdminNo desc");
            }
            strSql.Append(")AS Row, T.*  from Admin T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Admin";
			parameters[1].Value = "AdminNo";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

