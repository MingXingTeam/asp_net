using System;
using System.Data;
namespace ncu.mao.IDAL
{
	/// <summary>
	/// 接口层t_user
	/// </summary>
	public interface It_user
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int userid);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(ncu.mao.Model.t_user model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(ncu.mao.Model.t_user model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int userid);
		bool DeleteList(string useridlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		ncu.mao.Model.t_user GetModel(int userid);
		ncu.mao.Model.t_user DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
