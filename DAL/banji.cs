using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace bysj.DAL
{
	/// <summary>
	/// 数据访问类:banji
	/// </summary>
	public partial class banji
	{
		public banji()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(bysj.Model.banji model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.departmentId != null)
			{
				strSql1.Append("departmentId,");
				strSql2.Append("'"+model.departmentId+"',");
			}
			if (model.banjiId != null)
			{
				strSql1.Append("banjiId,");
				strSql2.Append("'"+model.banjiId+"',");
			}
			if (model.banjiName != null)
			{
				strSql1.Append("banjiName,");
				strSql2.Append("'"+model.banjiName+"',");
			}
			if (model.banzhuren != null)
			{
				strSql1.Append("banzhuren,");
				strSql2.Append("'"+model.banzhuren+"',");
			}
			if (model.入学年份 != null)
			{
				strSql1.Append("入学年份,");
				strSql2.Append("'"+model.入学年份+"',");
			}
			if (model.专业 != null)
			{
				strSql1.Append("专业,");
				strSql2.Append("'"+model.专业+"',");
			}
			strSql.Append("insert into banji(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(bysj.Model.banji model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update banji set ");
			if (model.departmentId != null)
			{
				strSql.Append("departmentId='"+model.departmentId+"',");
			}
			else
			{
				strSql.Append("departmentId= null ,");
			}
			if (model.banjiId != null)
			{
				strSql.Append("banjiId='"+model.banjiId+"',");
			}
			else
			{
				strSql.Append("banjiId= null ,");
			}
			if (model.banjiName != null)
			{
				strSql.Append("banjiName='"+model.banjiName+"',");
			}
			else
			{
				strSql.Append("banjiName= null ,");
			}
			if (model.banzhuren != null)
			{
				strSql.Append("banzhuren='"+model.banzhuren+"',");
			}
			else
			{
				strSql.Append("banzhuren= null ,");
			}
			if (model.入学年份 != null)
			{
				strSql.Append("入学年份='"+model.入学年份+"',");
			}
			else
			{
				strSql.Append("入学年份= null ,");
			}
			if (model.专业 != null)
			{
				strSql.Append("专业='"+model.专业+"',");
			}
			else
			{
				strSql.Append("专业= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ");
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from banji ");
			strSql.Append(" where " );
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public bysj.Model.banji GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" departmentId,banjiId,banjiName,banzhuren,入学年份,专业 ");
			strSql.Append(" from banji ");
			strSql.Append(" where " );
			bysj.Model.banji model=new bysj.Model.banji();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public bysj.Model.banji DataRowToModel(DataRow row)
		{
			bysj.Model.banji model=new bysj.Model.banji();
			if (row != null)
			{
				if(row["departmentId"]!=null)
				{
					model.departmentId=row["departmentId"].ToString();
				}
				if(row["banjiId"]!=null)
				{
					model.banjiId=row["banjiId"].ToString();
				}
				if(row["banjiName"]!=null)
				{
					model.banjiName=row["banjiName"].ToString();
				}
				if(row["banzhuren"]!=null)
				{
					model.banzhuren=row["banzhuren"].ToString();
				}
				if(row["入学年份"]!=null)
				{
					model.入学年份=row["入学年份"].ToString();
				}
				if(row["专业"]!=null)
				{
					model.专业=row["专业"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select departmentId,banjiId,banjiName,banzhuren,入学年份,专业 ");
			strSql.Append(" FROM banji ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM banji ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from banji T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

