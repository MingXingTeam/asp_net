using System;
namespace ncu.mao.Model
{
	/// <summary>
	/// role_privilege:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class role_privilege
	{
		public role_privilege()
		{}
		#region Model
		private int _id;
		private int? _rolesid;
		private int? _priviledgeid;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? rolesid
		{
			set{ _rolesid=value;}
			get{return _rolesid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? priviledgeid
		{
			set{ _priviledgeid=value;}
			get{return _priviledgeid;}
		}
		#endregion Model

	}
}

