using System;
using System.Data;
namespace Ncu.jsj.IDAL
{
	/// <summary>
	/// 接口层City
	/// </summary>
	public interface ICity
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int CityId);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(Ncu.jsj.Model.City model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Ncu.jsj.Model.City model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int CityId);
		bool DeleteList(string CityIdlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Ncu.jsj.Model.City GetModel(int CityId);
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
	} 
}
