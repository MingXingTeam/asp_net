using System;
using System.Reflection;
using System.Configuration;
namespace ncu.mao.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
	/// </summary>
	public sealed class DataAccess 
	{
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];        
		public DataAccess()
		{ }

        #region CreateObject 

		//不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// 记录错误日志
				return null;
			}			
			
        }
		//使用缓存
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.GetCache(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.SetCache(classNamespace, objType);// 写入缓存
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// 记录错误日志
				}
			}
			return objType;
		}
        #endregion

        #region 泛型生成
        ///// <summary>
        ///// 创建数据层接口。
        ///// </summary>
        //public static t Create(string ClassName)
        //{

        //    string ClassNamespace = AssemblyPath +"."+ ClassName;
        //    object objType = CreateObject(AssemblyPath, ClassNamespace);
        //    return (t)objType;
        //}
        #endregion

        #region CreateSysManage
        public static ncu.mao.IDAL.ISysManage CreateSysManage()
		{
			//方式1			
			//return (ncu.mao.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

			//方式2 			
			string classNamespace = AssemblyPath+".SysManage";	
			object objType=CreateObject(AssemblyPath,classNamespace);
            return (ncu.mao.IDAL.ISysManage)objType;		
		}
		#endregion
             
        
   
		/// <summary>
		/// 创建role_privilege数据层接口。
		/// </summary>
		public static ncu.mao.IDAL.Irole_privilege Createrole_privilege()
		{

			string ClassNamespace = AssemblyPath +".role_privilege";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (ncu.mao.IDAL.Irole_privilege)objType;
		}

		/// <summary>
		/// 创建t_privilege数据层接口。
		/// </summary>
		public static ncu.mao.IDAL.It_privilege Createt_privilege()
		{

			string ClassNamespace = AssemblyPath +".t_privilege";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (ncu.mao.IDAL.It_privilege)objType;
		}

		/// <summary>
		/// 创建t_role数据层接口。
		/// </summary>
		public static ncu.mao.IDAL.It_role Createt_role()
		{

			string ClassNamespace = AssemblyPath +".t_role";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (ncu.mao.IDAL.It_role)objType;
		}

		/// <summary>
		/// 创建t_user数据层接口。
		/// </summary>
		public static ncu.mao.IDAL.It_user Createt_user()
		{

			string ClassNamespace = AssemblyPath +".t_user";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (ncu.mao.IDAL.It_user)objType;
		}

		/// <summary>
		/// 创建user_roles数据层接口。
		/// </summary>
		public static ncu.mao.IDAL.Iuser_roles Createuser_roles()
		{

			string ClassNamespace = AssemblyPath +".user_roles";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (ncu.mao.IDAL.Iuser_roles)objType;
		}

}
}