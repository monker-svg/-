using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace bysj.DAL
{
	/// <summary>
	/// 数据访问类:studentinfo
	/// </summary>
	public partial class studentinfo
	{
		public studentinfo()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string StudentId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from studentinfo");
			strSql.Append(" where StudentId='"+StudentId+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(bysj.Model.studentinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.StudentId != null)
			{
				strSql1.Append("StudentId,");
				strSql2.Append("'"+model.StudentId+"',");
			}
			if (model.StudentName != null)
			{
				strSql1.Append("StudentName,");
				strSql2.Append("'"+model.StudentName+"',");
			}
			if (model.Banji != null)
			{
				strSql1.Append("Banji,");
				strSql2.Append("'"+model.Banji+"',");
			}
			if (model.Pwd != null)
			{
				strSql1.Append("Pwd,");
				strSql2.Append("'"+model.Pwd+"',");
			}
			if (model.phone != null)
			{
				strSql1.Append("phone,");
				strSql2.Append("'"+model.phone+"',");
			}
			if (model.QQ != null)
			{
				strSql1.Append("QQ,");
				strSql2.Append("'"+model.QQ+"',");
			}
			if (model.tmid != null)
			{
				strSql1.Append("tmid,");
				strSql2.Append(""+model.tmid+",");
			}
			if (model.stated != null)
			{
				strSql1.Append("stated,");
				strSql2.Append(""+model.stated+",");
			}
			if (model.remark != null)
			{
				strSql1.Append("remark,");
				strSql2.Append("'"+model.remark+"',");
			}
			strSql.Append("insert into studentinfo(");
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
		public bool Update(bysj.Model.studentinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update studentinfo set ");
			if (model.StudentName != null)
			{
				strSql.Append("StudentName='"+model.StudentName+"',");
			}
			else
			{
				strSql.Append("StudentName= null ,");
			}
			if (model.Banji != null)
			{
				strSql.Append("Banji='"+model.Banji+"',");
			}
			else
			{
				strSql.Append("Banji= null ,");
			}
			if (model.Pwd != null)
			{
				strSql.Append("Pwd='"+model.Pwd+"',");
			}
			else
			{
				strSql.Append("Pwd= null ,");
			}
			if (model.phone != null)
			{
				strSql.Append("phone='"+model.phone+"',");
			}
			else
			{
				strSql.Append("phone= null ,");
			}
			if (model.QQ != null)
			{
				strSql.Append("QQ='"+model.QQ+"',");
			}
			else
			{
				strSql.Append("QQ= null ,");
			}
			if (model.tmid != null)
			{
				strSql.Append("tmid="+model.tmid+",");
			}
			else
			{
				strSql.Append("tmid= null ,");
			}
			if (model.stated != null)
			{
				strSql.Append("stated="+model.stated+",");
			}
			else
			{
				strSql.Append("stated= null ,");
			}
			if (model.remark != null)
			{
				strSql.Append("remark='"+model.remark+"',");
			}
			else
			{
				strSql.Append("remark= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where StudentId='"+ model.StudentId+"' ");
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
		public bool Delete(string StudentId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from studentinfo ");
			strSql.Append(" where StudentId='"+StudentId+"' " );
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string StudentIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from studentinfo ");
			strSql.Append(" where StudentId in ("+StudentIdlist + ")  ");
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
		/// 得到一个对象实体
		/// </summary>
		public bysj.Model.studentinfo GetModel(string StudentId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" StudentId,StudentName,Banji,Pwd,phone,QQ,tmid,stated,remark ");
			strSql.Append(" from studentinfo ");
			strSql.Append(" where StudentId='"+StudentId+"' " );
			bysj.Model.studentinfo model=new bysj.Model.studentinfo();
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
		public bysj.Model.studentinfo DataRowToModel(DataRow row)
		{
			bysj.Model.studentinfo model=new bysj.Model.studentinfo();
			if (row != null)
			{
				if(row["StudentId"]!=null)
				{
					model.StudentId=row["StudentId"].ToString();
				}
				if(row["StudentName"]!=null)
				{
					model.StudentName=row["StudentName"].ToString();
				}
				if(row["Banji"]!=null)
				{
					model.Banji=row["Banji"].ToString();
				}
				if(row["Pwd"]!=null)
				{
					model.Pwd=row["Pwd"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["QQ"]!=null)
				{
					model.QQ=row["QQ"].ToString();
				}
				if(row["tmid"]!=null && row["tmid"].ToString()!="")
				{
					model.tmid=int.Parse(row["tmid"].ToString());
				}
				if(row["stated"]!=null && row["stated"].ToString()!="")
				{
					model.stated=int.Parse(row["stated"].ToString());
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
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
			strSql.Append("select StudentId,StudentName,Banji,Pwd,phone,QQ,tmid,stated,remark ");
			strSql.Append(" FROM studentinfo ");
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
			strSql.Append("select count(1) FROM studentinfo ");
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
				strSql.Append("order by T.StudentId desc");
			}
			strSql.Append(")AS Row, T.*  from studentinfo T ");
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

