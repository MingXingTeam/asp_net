using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ncu.mao.Model;
using ncu.mao.DALFactory;
using ncu.mao.IDAL;
namespace ncu.mao.BLL
{
	/// <summary>
	/// t_role
	/// </summary>
	public partial class t_role
	{
		private readonly It_role dal=DataAccess.Createt_role();
		public t_role()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int roleid)
		{
			return dal.Exists(roleid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ncu.mao.Model.t_role model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ncu.mao.Model.t_role model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int roleid)
		{
			
			return dal.Delete(roleid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string roleidlist )
		{
			return dal.DeleteList(roleidlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ncu.mao.Model.t_role GetModel(int roleid)
		{
			
			return dal.GetModel(roleid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ncu.mao.Model.t_role GetModelByCache(int roleid)
		{
			
			string CacheKey = "t_roleModel-" + roleid;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(roleid);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ncu.mao.Model.t_role)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ncu.mao.Model.t_role> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ncu.mao.Model.t_role> DataTableToList(DataTable dt)
		{
			List<ncu.mao.Model.t_role> modelList = new List<ncu.mao.Model.t_role>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ncu.mao.Model.t_role model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

