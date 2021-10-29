using System;
namespace bysj.Model
{
	/// <summary>
	/// studentinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class studentinfo
	{
		public studentinfo()
		{}
		#region Model
		private string _studentid;
		private string _studentname;
		private string _banji;
		private string _pwd;
		private string _phone;
		private string _qq;
		private int _tmid;
		private int _stated;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string StudentId
		{
			set{ _studentid=value;}
			get{return _studentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StudentName
		{
			set{ _studentname=value;}
			get{return _studentname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Banji
		{
			set{ _banji=value;}
			get{return _banji;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tmid
		{
			set{ _tmid=value;}
			get{return _tmid;}
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
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

