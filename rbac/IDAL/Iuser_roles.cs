﻿using System;
using System.Data;
namespace ncu.mao.IDAL
{
	/// <summary>
	/// 接口层user_roles
	/// </summary>
	public interface Iuser_roles
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int id);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(ncu.mao.Model.user_roles model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(ncu.mao.Model.user_roles model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int rolesid);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int id);
		bool DeleteList(string rolesidlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		ncu.mao.Model.user_roles GetModel(int rolesid);
		ncu.mao.Model.user_roles DataRowToModel(DataRow row);
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
