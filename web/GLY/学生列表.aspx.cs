using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web.GLY
{
    public partial class 学生列表 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bysj.DAL.studentinfo studentinfoDal = new bysj.DAL.studentinfo();
                Repeater1.DataSource = studentinfoDal.GetList("");
                Repeater1.DataBind();
            }

            string name = Request.Params[""];
        }
    }
}