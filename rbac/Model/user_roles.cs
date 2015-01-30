using System;
namespace ncu.mao.Model
{
	/// <summary>
	/// user_roles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user_roles
	{
		public user_roles()
		{}
		#region Model
		private int _id;
		private int? _userid;
		private int _rolesid;
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
		public int? userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int rolesid
		{
			set{ _rolesid=value;}
			get{return _rolesid;}
		}
		#endregion Model

	}
}

