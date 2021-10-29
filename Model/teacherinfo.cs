using System;
namespace bysj.Model
{
	/// <summary>
	/// teacherinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class teacherinfo
	{
		public teacherinfo()
		{}
		#region Model
		private string _teacherid;
		private string _teacherpwd;
		private string _teachername;
		private string _phone;
		private string _qq;
		private int _manager;
		private int _stated;
		private string _jys;
		private string _departmentid;
		/// <summary>
		/// 
		/// </summary>
		public string TeacherId
		{
			set{ _teacherid=value;}
			get{return _teacherid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeacherPwd
		{
			set{ _teacherpwd=value;}
			get{return _teacherpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeacherName
		{
			set{ _teachername=value;}
			get{return _teachername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int manager
		{
			set{ _manager=value;}
			get{return _manager;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int stated
		{
			set{ _stated=value;}
			get{return _stated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JYS
		{
			set{ _jys=value;}
			get{return _jys;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string departmentId
		{
			set{ _departmentid=value;}
			get{return _departmentid;}
		}
		#endregion Model

	}
}

