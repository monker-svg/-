using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using bysj.Model;
namespace bysj.BLL
{
	/// <summary>
	/// sjtm
	/// </summary>
	public partial class sjtm
	{
		private readonly bysj.DAL.sjtm dal=new bysj.DAL.sjtm();
		public sjtm()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int tmId)
		{
			return dal.Exists(tmId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(bysj.Model.sjtm model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(bysj.Model.sjtm model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int tmId)
		{
			
			return dal.Delete(tmId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string tmIdlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(tmIdlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public bysj.Model.sjtm GetModel(int tmId)
		{
			
			return dal.GetModel(tmId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public bysj.Model.sjtm GetModelByCache(int tmId)
		{
			
			string CacheKey = "sjtmModel-" + tmId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(tmId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (bysj.Model.sjtm)objModel;
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
		public List<bysj.Model.sjtm> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<bysj.Model.sjtm> DataTableToList(DataTable dt)
		{
			List<bysj.Model.sjtm> modelList = new List<bysj.Model.sjtm>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				bysj.Model.sjtm model;
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

