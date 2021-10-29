using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using bysj.Model;
namespace bysj.BLL
{
	/// <summary>
	/// studentinfo
	/// </summary>
	public partial class studentinfo
	{
		private readonly bysj.DAL.studentinfo dal=new bysj.DAL.studentinfo();
		public studentinfo()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string StudentId)
		{
			return dal.Exists(StudentId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(bysj.Model.studentinfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(bysj.Model.studentinfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string StudentId)
		{
			
			return dal.Delete(StudentId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string StudentIdlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(StudentIdlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public bysj.Model.studentinfo GetModel(string StudentId)
		{
			
			return dal.GetModel(StudentId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public bysj.Model.studentinfo GetModelByCache(string StudentId)
		{
			
			string CacheKey = "studentinfoModel-" + StudentId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(StudentId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (bysj.Model.studentinfo)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<bysj.Model.studentinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<bysj.Model.studentinfo> DataTableToList(DataTable dt)
		{
			List<bysj.Model.studentinfo> modelList = new List<bysj.Model.studentinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				bysj.Model.studentinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

