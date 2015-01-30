﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ncu.mao.Model;
using ncu.mao.DALFactory;
using ncu.mao.IDAL;
namespace ncu.mao.BLL
{
	/// <summary>
	/// user_roles
	/// </summary>
	public partial class user_roles
	{
		private readonly Iuser_roles dal=DataAccess.Createuser_roles();
		public user_roles()
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
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ncu.mao.Model.user_roles model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ncu.mao.Model.user_roles model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int rolesid)
		{
			
			return dal.Delete(rolesid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string rolesidlist )
		{
			return dal.DeleteList(rolesidlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ncu.mao.Model.user_roles GetModel(int rolesid)
		{
			
			return dal.GetModel(rolesid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ncu.mao.Model.user_roles GetModelByCache(int rolesid)
		{
			
			string CacheKey = "user_rolesModel-" + rolesid;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(rolesid);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ncu.mao.Model.user_roles)objModel;
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
		public List<ncu.mao.Model.user_roles> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ncu.mao.Model.user_roles> DataTableToList(DataTable dt)
		{
			List<ncu.mao.Model.user_roles> modelList = new List<ncu.mao.Model.user_roles>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ncu.mao.Model.user_roles model;
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

