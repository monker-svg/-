using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace bysj.DAL
{
	/// <summary>
	/// 数据访问类:teacherinfo
	/// </summary>
	public partial class teacherinfo
	{
		public teacherinfo()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string TeacherId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from teacherinfo");
			strSql.Append(" where TeacherId='"+TeacherId+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(bysj.Model.teacherinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.TeacherId != null)
			{
				strSql1.Append("TeacherId,");
				strSql2.Append("'"+model.TeacherId+"',");
			}
			if (model.TeacherPwd != null)
			{
				strSql1.Append("TeacherPwd,");
				strSql2.Append("'"+model.TeacherPwd+"',");
			}
			if (model.TeacherName != null)
			{
				strSql1.Append("TeacherName,");
				strSql2.Append("'"+model.TeacherName+"',");
			}
			if (model.Phone != null)
			{
				strSql1.Append("Phone,");
				strSql2.Append("'"+model.Phone+"',");
			}
			if (model.qq != null)
			{
				strSql1.Append("qq,");
				strSql2.Append("'"+model.qq+"',");
			}
			if (model.manager != null)
			{
				strSql1.Append("manager,");
				strSql2.Append(""+model.manager+",");
			}
			if (model.stated != null)
			{
				strSql1.Append("stated,");
				strSql2.Append(""+model.stated+",");
			}
			if (model.JYS != null)
			{
				strSql1.Append("JYS,");
				strSql2.Append("'"+model.JYS+"',");
			}
			if (model.departmentId != null)
			{
				strSql1.Append("departmentId,");
				strSql2.Append("'"+model.departmentId+"',");
			}
			strSql.Append("insert into teacherinfo(");
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
		public bool Update(bysj.Model.teacherinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update teacherinfo set ");
			if (model.TeacherPwd != null)
			{
				strSql.Append("TeacherPwd='"+model.TeacherPwd+"',");
			}
			else
			{
				strSql.Append("TeacherPwd= null ,");
			}
			if (model.TeacherName != null)
			{
				strSql.Append("TeacherName='"+model.TeacherName+"',");
			}
			else
			{
				strSql.Append("TeacherName= null ,");
			}
			if (model.Phone != null)
			{
				strSql.Append("Phone='"+model.Phone+"',");
			}
			else
			{
				strSql.Append("Phone= null ,");
			}
			if (model.qq != null)
			{
				strSql.Append("qq='"+model.qq+"',");
			}
			else
			{
				strSql.Append("qq= null ,");
			}
			if (model.manager != null)
			{
				strSql.Append("manager="+model.manager+",");
			}
			else
			{
				strSql.Append("manager= null ,");
			}
			if (model.stated != null)
			{
				strSql.Append("stated="+model.stated+",");
			}
			else
			{
				strSql.Append("stated= null ,");
			}
			if (model.JYS != null)
			{
				strSql.Append("JYS='"+model.JYS+"',");
			}
			else
			{
				strSql.Append("JYS= null ,");
			}
			if (model.departmentId != null)
			{
				strSql.Append("departmentId='"+model.departmentId+"',");
			}
			else
			{
				strSql.Append("departmentId= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where TeacherId='"+ model.TeacherId+"' ");
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
		public bool Delete(string TeacherId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from teacherinfo ");
			strSql.Append(" where TeacherId='"+TeacherId+"' " );
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
		public bool DeleteList(string TeacherIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from teacherinfo ");
			strSql.Append(" where TeacherId in ("+TeacherIdlist + ")  ");
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
		public bysj.Model.teacherinfo GetModel(string TeacherId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" TeacherId,TeacherPwd,TeacherName,Phone,qq,manager,stated,JYS,departmentId ");
			strSql.Append(" from teacherinfo ");
			strSql.Append(" where TeacherId='"+TeacherId+"' " );
			bysj.Model.teacherinfo model=new bysj.Model.teacherinfo();
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
		public bysj.Model.teacherinfo DataRowToModel(DataRow row)
		{
			bysj.Model.teacherinfo model=new bysj.Model.teacherinfo();
			if (row != null)
			{
				if(row["TeacherId"]!=null)
				{
					model.TeacherId=row["TeacherId"].ToString();
				}
				if(row["TeacherPwd"]!=null)
				{
					model.TeacherPwd=row["TeacherPwd"].ToString();
				}
				if(row["TeacherName"]!=null)
				{
					model.TeacherName=row["TeacherName"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["qq"]!=null)
				{
					model.qq=row["qq"].ToString();
				}
				if(row["manager"]!=null && row["manager"].ToString()!="")
				{
					model.manager=int.Parse(row["manager"].ToString());
				}
				if(row["stated"]!=null && row["stated"].ToString()!="")
				{
					model.stated=int.Parse(row["stated"].ToString());
				}
				if(row["JYS"]!=null)
				{
					model.JYS=row["JYS"].ToString();
				}
				if(row["departmentId"]!=null)
				{
					model.departmentId=row["departmentId"].ToString();
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
			strSql.Append("select * ");
			strSql.Append("FROM teacherinfo");
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
			strSql.Append("select count(1) FROM teacherinfo ");
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
				strSql.Append("order by T.TeacherId desc");
			}
			strSql.Append(")AS Row, T.*  from teacherinfo T ");
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

