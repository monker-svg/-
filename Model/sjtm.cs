using System;
namespace bysj.Model
{
	/// <summary>
	/// sjtm:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sjtm
	{
		public sjtm()
		{}
		#region Model
		private int _tmid;
		private string _teacherid;
		private string _tmname;
		private string _tmtype;
		private int _state;
		private string _年度;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int tmId
		{
			set{ _tmid=value;}
			get{return _tmid;}
		}
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
		public string tmName
		{
			set{ _tmname=value;}
			get{return _tmname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tmType
		{
			set{ _tmtype=value;}
			get{return _tmtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 年度
		{
			set{ _年度=value;}
			get{return _年度;}
		}
		#endregion Model

	}
}

