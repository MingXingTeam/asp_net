using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ncu.mao.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace ncu.mao.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_privilege
	/// </summary>
	public partial class t_privilege:It_privilege
	{
		public t_privilege()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("privilegeid", "t_privilege"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int privilegeid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_privilege");
			strSql.Append(" where privilegeid=@privilegeid ");
			SqlParameter[] parameters = {
					new SqlParameter("@privilegeid", SqlDbType.Int,4)			};
			parameters[0].Value = privilegeid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ncu.mao.Model.t_privilege model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_privilege(");
			strSql.Append("privilegeid,privilegename,discription,url,flag)");
			strSql.Append(" values (");
			strSql.Append("@privilegeid,@privilegename,@discription,@url,@flag)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@privilegeid", SqlDbType.Int,4),
					new SqlParameter("@privilegename", SqlDbType.NVarChar,20),
					new SqlParameter("@discription", SqlDbType.NVarChar,50),
					new SqlParameter("@url", SqlDbType.NVarChar,50),
					new SqlParameter("@flag", SqlDbType.Bit,1)};
			parameters[0].Value = model.privilegeid;
			parameters[1].Value = model.privilegename;
			parameters[2].Value = model.discription;
			parameters[3].Value = model.url;
			parameters[4].Value = model.flag;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(ncu.mao.Model.t_privilege model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_privilege set ");
			strSql.Append("privilegename=@privilegename,");
			strSql.Append("discription=@discription,");
			strSql.Append("url=@url,");
			strSql.Append("flag=@flag");
			strSql.Append(" where parentid=@parentid");
			SqlParameter[] parameters = {
					new SqlParameter("@privilegename", SqlDbType.NVarChar,20),
					new SqlParameter("@discription", SqlDbType.NVarChar,50),
					new SqlParameter("@url", SqlDbType.NVarChar,50),
					new SqlParameter("@flag", SqlDbType.Bit,1),
					new SqlParameter("@privilegeid", SqlDbType.Int,4),
					new SqlParameter("@parentid", SqlDbType.Int,4)};
			parameters[0].Value = model.privilegename;
			parameters[1].Value = model.discription;
			parameters[2].Value = model.url;
			parameters[3].Value = model.flag;
			parameters[4].Value = model.privilegeid;
			parameters[5].Value = model.parentid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int parentid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_privilege ");
			strSql.Append(" where parentid=@parentid");
			SqlParameter[] parameters = {
					new SqlParameter("@parentid", SqlDbType.Int,4)
			};
			parameters[0].Value = parentid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int privilegeid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_privilege ");
			strSql.Append(" where privilegeid=@privilegeid ");
			SqlParameter[] parameters = {
					new SqlParameter("@privilegeid", SqlDbType.Int,4)			};
			parameters[0].Value = privilegeid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string parentidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_privilege ");
			strSql.Append(" where parentid in ("+parentidlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public ncu.mao.Model.t_privilege GetModel(int parentid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 privilegeid,privilegename,discription,url,flag,parentid from t_privilege ");
			strSql.Append(" where parentid=@parentid");
			SqlParameter[] parameters = {
					new SqlParameter("@parentid", SqlDbType.Int,4)
			};
			parameters[0].Value = parentid;

			ncu.mao.Model.t_privilege model=new ncu.mao.Model.t_privilege();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public ncu.mao.Model.t_privilege DataRowToModel(DataRow row)
		{
			ncu.mao.Model.t_privilege model=new ncu.mao.Model.t_privilege();
			if (row != null)
			{
				if(row["privilegeid"]!=null && row["privilegeid"].ToString()!="")
				{
					model.privilegeid=int.Parse(row["privilegeid"].ToString());
				}
				if(row["privilegename"]!=null)
				{
					model.privilegename=row["privilegename"].ToString();
				}
				if(row["discription"]!=null)
				{
					model.discription=row["discription"].ToString();
				}
				if(row["url"]!=null)
				{
					model.url=row["url"].ToString();
				}
				if(row["flag"]!=null && row["flag"].ToString()!="")
				{
					if((row["flag"].ToString()=="1")||(row["flag"].ToString().ToLower()=="true"))
					{
						model.flag=true;
					}
					else
					{
						model.flag=false;
					}
				}
				if(row["parentid"]!=null && row["parentid"].ToString()!="")
				{
					model.parentid=int.Parse(row["parentid"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select privilegeid,privilegename,discription,url,flag,parentid ");
			strSql.Append(" FROM t_privilege ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" privilegeid,privilegename,discription,url,flag,parentid ");
			strSql.Append(" FROM t_privilege ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM t_privilege ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.parentid desc");
			}
			strSql.Append(")AS Row, T.*  from t_privilege T ");
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
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "t_privilege";
			parameters[1].Value = "parentid";
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

