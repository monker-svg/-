using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace bysj.DAL
{
	/// <summary>
	/// 数据访问类:sjtm
	/// </summary>
	public partial class sjtm
	{
		public sjtm()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("tmId", "sjtm"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int tmId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sjtm");
			strSql.Append(" where tmId="+tmId+" ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(bysj.Model.sjtm model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.TeacherId != null)
			{
				strSql1.Append("TeacherId,");
				strSql2.Append("'"+model.TeacherId+"',");
			}
			if (model.tmName != null)
			{
				strSql1.Append("tmName,");
				strSql2.Append("'"+model.tmName+"',");
			}
			if (model.tmType != null)
			{
				strSql1.Append("tmType,");
				strSql2.Append("'"+model.tmType+"',");
			}
			if (model.state != null)
			{
				strSql1.Append("state,");
				strSql2.Append(""+model.state+",");
			}
			if (model.年度 != null)
			{
				strSql1.Append("年度,");
				strSql2.Append("'"+model.年度+"',");
			}
			strSql.Append("insert into sjtm(");
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
		public bool Update(bysj.Model.sjtm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sjtm set ");
			if (model.TeacherId != null)
			{
				strSql.Append("TeacherId='"+model.TeacherId+"',");
			}
			else
			{
				strSql.Append("TeacherId= null ,");
			}
			if (model.tmName != null)
			{
				strSql.Append("tmName='"+model.tmName+"',");
			}
			else
			{
				strSql.Append("tmName= null ,");
			}
			if (model.tmType != null)
			{
				strSql.Append("tmType='"+model.tmType+"',");
			}
			else
			{
				strSql.Append("tmType= null ,");
			}
			if (model.state != null)
			{
				strSql.Append("state="+model.state+",");
			}
			else
			{
				strSql.Append("state= null ,");
			}
			if (model.年度 != null)
			{
				strSql.Append("年度='"+model.年度+"',");
			}
			else
			{
				strSql.Append("年度= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where tmId="+ model.tmId+"");
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
		public bool Delete(int tmId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sjtm ");
			strSql.Append(" where tmId="+tmId+"" );
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
		public bool DeleteList(string tmIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sjtm ");
			strSql.Append(" where tmId in ("+tmIdlist + ")  ");
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
		public bysj.Model.sjtm GetModel(int tmId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" tmId,TeacherId,tmName,tmType,state,年度 ");
			strSql.Append(" from sjtm ");
			strSql.Append(" where tmId="+tmId+"" );
			bysj.Model.sjtm model=new bysj.Model.sjtm();
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
		public bysj.Model.sjtm DataRowToModel(DataRow row)
		{
			bysj.Model.sjtm model=new bysj.Model.sjtm();
			if (row != null)
			{
				if(row["tmId"]!=null && row["tmId"].ToString()!="")
				{
					model.tmId=int.Parse(row["tmId"].ToString());
				}
				if(row["TeacherId"]!=null)
				{
					model.TeacherId=row["TeacherId"].ToString();
				}
				if(row["tmName"]!=null)
				{
					model.tmName=row["tmName"].ToString();
				}
				if(row["tmType"]!=null)
				{
					model.tmType=row["tmType"].ToString();
				}
				if(row["state"]!=null && row["state"].ToString()!="")
				{
					model.state=int.Parse(row["state"].ToString());
				}
				if(row["年度"]!=null)
				{
					model.年度=row["年度"].ToString();
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
			strSql.Append("select tmId,TeacherId,tmName,tmType,state,年度 ");
			strSql.Append(" FROM sjtm ");
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
			strSql.Append("select count(1) FROM sjtm ");
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
				strSql.Append("order by T.tmId desc");
			}
			strSql.Append(")AS Row, T.*  from sjtm T ");
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

