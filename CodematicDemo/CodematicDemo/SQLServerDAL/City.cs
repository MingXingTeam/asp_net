using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Ncu.jsj.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Ncu.jsj.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:City
	/// </summary>
	public partial class City:ICity
	{
		public City()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CityId", "City"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CityId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from City");
			strSql.Append(" where CityId=@CityId ");
			SqlParameter[] parameters = {
					new SqlParameter("@CityId", SqlDbType.Int,4)			};
			parameters[0].Value = CityId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Ncu.jsj.Model.City model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into City(");
			strSql.Append("CityId,ProvinceId,CityName)");
			strSql.Append(" values (");
			strSql.Append("@CityId,@ProvinceId,@CityName)");
			SqlParameter[] parameters = {
					new SqlParameter("@CityId", SqlDbType.Int,4),
					new SqlParameter("@ProvinceId", SqlDbType.Int,4),
					new SqlParameter("@CityName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.CityId;
			parameters[1].Value = model.ProvinceId;
			parameters[2].Value = model.CityName;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Ncu.jsj.Model.City model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update City set ");
			strSql.Append("ProvinceId=@ProvinceId,");
			strSql.Append("CityName=@CityName");
			strSql.Append(" where CityId=@CityId ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProvinceId", SqlDbType.Int,4),
					new SqlParameter("@CityName", SqlDbType.VarChar,50),
					new SqlParameter("@CityId", SqlDbType.Int,4)};
			parameters[0].Value = model.ProvinceId;
			parameters[1].Value = model.CityName;
			parameters[2].Value = model.CityId;

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
		public bool Delete(int CityId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from City ");
			strSql.Append(" where CityId=@CityId ");
			SqlParameter[] parameters = {
					new SqlParameter("@CityId", SqlDbType.Int,4)			};
			parameters[0].Value = CityId;

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
		public bool DeleteList(string CityIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from City ");
			strSql.Append(" where CityId in ("+CityIdlist + ")  ");
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
		public Ncu.jsj.Model.City GetModel(int CityId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CityId,ProvinceId,CityName from City ");
			strSql.Append(" where CityId=@CityId ");
			SqlParameter[] parameters = {
					new SqlParameter("@CityId", SqlDbType.Int,4)			};
			parameters[0].Value = CityId;

			Ncu.jsj.Model.City model=new Ncu.jsj.Model.City();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["CityId"]!=null && ds.Tables[0].Rows[0]["CityId"].ToString()!="")
				{
					model.CityId=int.Parse(ds.Tables[0].Rows[0]["CityId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProvinceId"]!=null && ds.Tables[0].Rows[0]["ProvinceId"].ToString()!="")
				{
					model.ProvinceId=int.Parse(ds.Tables[0].Rows[0]["ProvinceId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CityName"]!=null && ds.Tables[0].Rows[0]["CityName"].ToString()!="")
				{
					model.CityName=ds.Tables[0].Rows[0]["CityName"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CityId,ProvinceId,CityName ");
			strSql.Append(" FROM City ");
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
			strSql.Append(" CityId,ProvinceId,CityName ");
			strSql.Append(" FROM City ");
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
			strSql.Append("select count(1) FROM City ");
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
				strSql.Append("order by T.CityId desc");
			}
			strSql.Append(")AS Row, T.*  from City T ");
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
			parameters[0].Value = "City";
			parameters[1].Value = "CityId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

