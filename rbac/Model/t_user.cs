using System;
namespace ncu.mao.Model
{
	/// <summary>
	/// t_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_user
	{
		public t_user()
		{}
		#region Model
		private int _userid;
		private string _username;
		private int? _age;
		private string _addr;
		/// <summary>
		/// 
		/// </summary>
		public int userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string addr
		{
			set{ _addr=value;}
			get{return _addr;}
		}
		#endregion Model

	}
}

