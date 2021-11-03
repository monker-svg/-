using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web.GLY
{
    public partial class 系别列表 : System.Web.UI.Page
    {

        bysj.DAL.banji banjiDal = new bysj.DAL.banji();

        protected void Page_Load(object sender, EventArgs e)
        {
            bysj.DAL.departmentinfo departmentinfoDal = new bysj.DAL.departmentinfo();
            DataTable dt = departmentinfoDal.GetList("").Tables[0];
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }


        protected void rptCategoryList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                DataRowView drv = (DataRowView)e.Item.DataItem;
                Repeater Repeater2 = (Repeater)e.Item.FindControl("Repeater2");
                Repeater2.DataSource = banjiDal.GetList(" departmentId=" + Convert.ToInt32(drv["DepartmentId"]));
                Repeater2.DataBind();
            }
        }

        protected void rptProductList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                DataRowView drv = (DataRowView)e.Item.DataItem;
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name =  TextBox1.Text;

           if(!string.IsNullOrEmpty(name.Trim())) { 

            bysj.DAL.departmentinfo departmentinfoDal = new bysj.DAL.departmentinfo();
            DataTable dt = departmentinfoDal.GetList("  DepartmentName like '%" + name + "%'").Tables[0];
            for(int i = 0; i < dt.Rows.Count; i++)
            {
               String ss =   Convert.ToString(dt.Rows[i]["DepartmentName"]).Replace(name, "<strong style='color:red;'>" + name + "</strong>");
                    dt.Rows[i]["DepartmentName"] = ss;
            }
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            }

        }
    }
}