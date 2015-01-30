using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Ncu.jsj.Model;
using Ncu.jsj.DALFactory;
using Ncu.jsj.IDAL;
namespace Ncu.jsj.BLL
{
	/// <summary>
	/// City
	/// </summary>
	public partial class City
	{
		private readonly ICity dal=DataAccess.CreateCity();
		public City()
		{}
		#region  Method

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
		public bool Exists(int CityId)
		{
			return dal.Exists(CityId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Ncu.jsj.Model.City model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Ncu.jsj.Model.City model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int CityId)
		{
			
			return dal.Delete(CityId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CityIdlist )
		{
			return dal.DeleteList(CityIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Ncu.jsj.Model.City GetModel(int CityId)
		{
			
			return dal.GetModel(CityId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Ncu.jsj.Model.City GetModelByCache(int CityId)
		{
			
			string CacheKey = "CityModel-" + CityId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CityId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Ncu.jsj.Model.City)objModel;
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
		public List<Ncu.jsj.Model.City> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Ncu.jsj.Model.City> DataTableToList(DataTable dt)
		{
			List<Ncu.jsj.Model.City> modelList = new List<Ncu.jsj.Model.City>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Ncu.jsj.Model.City model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Ncu.jsj.Model.City();
					if(dt.Rows[n]["CityId"]!=null && dt.Rows[n]["CityId"].ToString()!="")
					{
						model.CityId=int.Parse(dt.Rows[n]["CityId"].ToString());
					}
					if(dt.Rows[n]["ProvinceId"]!=null && dt.Rows[n]["ProvinceId"].ToString()!="")
					{
						model.ProvinceId=int.Parse(dt.Rows[n]["ProvinceId"].ToString());
					}
					if(dt.Rows[n]["CityName"]!=null && dt.Rows[n]["CityName"].ToString()!="")
					{
					model.CityName=dt.Rows[n]["CityName"].ToString();
					}
					modelList.Add(model);
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

		#endregion  Method
	}
}

