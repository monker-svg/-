using System;
namespace bysj.Model
{
	/// <summary>
	/// banji:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class banji
	{
		public banji()
		{}
		#region Model
		private string _departmentid;
		private string _banjiid;
		private string _banjiname;
		private string _banzhuren;
		private string _入学年份;
		private string _专业;
		/// <summary>
		/// 
		/// </summary>
		public string departmentId
		{
			set{ _departmentid=value;}
			get{return _departmentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string banjiId
		{
			set{ _banjiid=value;}
			get{return _banjiid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string banjiName
		{
			set{ _banjiname=value;}
			get{return _banjiname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string banzhuren
		{
			set{ _banzhuren=value;}
			get{return _banzhuren;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 入学年份
		{
			set{ _入学年份=value;}
			get{return _入学年份;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 专业
		{
			set{ _专业=value;}
			get{return _专业;}
		}
		#endregion Model

	}
}

