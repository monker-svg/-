using System;
namespace bysj.Model
{
	/// <summary>
	/// departmentinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class departmentinfo
	{
		public departmentinfo()
		{}
		#region Model
		private string _departmentid;
		private string _departmentname;
		/// <summary>
		/// 
		/// </summary>
		public string DepartmentId
		{
			set{ _departmentid=value;}
			get{return _departmentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DepartmentName
		{
			set{ _departmentname=value;}
			get{return _departmentname;}
		}
		#endregion Model

	}
}

