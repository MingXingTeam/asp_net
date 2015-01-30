using System;
namespace ncu.mao.Model
{
	/// <summary>
	/// t_role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_role
	{
		public t_role()
		{}
		#region Model
		private int _roleid;
		private string _rolename;
		private string _description;
		/// <summary>
		/// 
		/// </summary>
		public int roleid
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rolename
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string description
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

