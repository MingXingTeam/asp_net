using System;
namespace Ncu.jsj.Model
{
	/// <summary>
	/// Student:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Student
	{
		public Student()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _age;
		private string _pictureurl;
        private bool _sex;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string pictureurl
		{
			set{ _pictureurl=value;}
			get{return _pictureurl;}
		}

        public bool sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
		#endregion Model

	}
}

