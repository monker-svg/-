using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bysj.Model.teacherinfo model = new bysj.Model.teacherinfo();
            bysj.DAL.teacherinfo dal = new bysj.DAL.teacherinfo();
            model = dal.GetModel(TextBox1.Text );
            Response.Write(model.TeacherName);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            bysj.DAL.teacherinfo dal = new bysj.DAL.teacherinfo();
            ds = dal.GetList("JYS='软件教研室'");

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}