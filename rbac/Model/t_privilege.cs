using System;
namespace ncu.mao.Model
{
	/// <summary>
	/// t_privilege:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_privilege
	{
		public t_privilege()
		{}
		#region Model
		private int _privilegeid;
		private string _privilegename;
		private string _discription;
		private string _url;
		private bool _flag;
		private int _parentid;
		/// <summary>
		/// 
		/// </summary>
		public int privilegeid
		{
			set{ _privilegeid=value;}
			get{return _privilegeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string privilegename
		{
			set{ _privilegename=value;}
			get{return _privilegename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string discription
		{
			set{ _discription=value;}
			get{return _discription;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int parentid
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		#endregion Model

	}
}

