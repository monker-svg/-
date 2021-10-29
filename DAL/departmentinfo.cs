using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace bysj.DAL
{
	/// <summary>
	/// 数据访问类:departmentinfo
	/// </summary>
	public partial class departmentinfo
	{
		public departmentinfo()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(bysj.Model.departmentinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.DepartmentId != null)
			{
				strSql1.Append("DepartmentId,");
				strSql2.Append("'"+model.DepartmentId+"',");
			}
			if (model.DepartmentName != null)
			{
				strSql1.Append("DepartmentName,");
				strSql2.Append("'"+model.DepartmentName+"',");
			}
			strSql.Append("insert into departmentinfo(");
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
		public bool Update(bysj.Model.departmentinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update departmentinfo set ");
			if (model.DepartmentId != null)
			{
				strSql.Append("DepartmentId='"+model.DepartmentId+"',");
			}
			else
			{
				strSql.Append("DepartmentId= null ,");
			}
			if (model.DepartmentName != null)
			{
				strSql.Append("DepartmentName='"+model.DepartmentName+"',");
			}
			else
			{
				strSql.Append("DepartmentName= null ,");
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
			strSql.Append("delete from departmentinfo ");
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
		public bysj.Model.departmentinfo GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" DepartmentId,DepartmentName ");
			strSql.Append(" from departmentinfo ");
			strSql.Append(" where " );
			bysj.Model.departmentinfo model=new bysj.Model.departmentinfo();
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
		public bysj.Model.departmentinfo DataRowToModel(DataRow row)
		{
			bysj.Model.departmentinfo model=new bysj.Model.departmentinfo();
			if (row != null)
			{
				if(row["DepartmentId"]!=null)
				{
					model.DepartmentId=row["DepartmentId"].ToString();
				}
				if(row["DepartmentName"]!=null)
				{
					model.DepartmentName=row["DepartmentName"].ToString();
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
			strSql.Append("select DepartmentId,DepartmentName ");
			strSql.Append(" FROM departmentinfo ");
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
			strSql.Append("select count(1) FROM departmentinfo ");
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
			strSql.Append(")AS Row, T.*  from departmentinfo T ");
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

