using System;
namespace Ncu.jsj.Model
{
	/// <summary>
	/// City:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class City
	{
		public City()
		{}
		#region Model
		private int _cityid;
		private int _provinceid;
		private string _cityname;
		/// <summary>
		/// 
		/// </summary>
		public int CityId
		{
			set{ _cityid=value;}
			get{return _cityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ProvinceId
		{
			set{ _provinceid=value;}
			get{return _provinceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CityName
		{
			set{ _cityname=value;}
			get{return _cityname;}
		}
		#endregion Model

	}
}

