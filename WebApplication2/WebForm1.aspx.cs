using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bysj.Model.teacherinfo model = new bysj.Model.teacherinfo();
            bysj.BLL.teacherinfo bll = new bysj.BLL.teacherinfo();
            model = bll.GetModel("2220282995");
            Response.Write(model.TeacherName);
        }
    }
}