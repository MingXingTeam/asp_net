using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ncu.jsj.Web
{
    public partial class GridViewStudent_sql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ncu.jsj.BLL.Student bll = new BLL.Student();
            GridView1.DataSource = bll.GetAllList();
            GridView1.DataBind();

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow gr in GridView1.Rows)
            {

                ((CheckBox)gr.Cells[4].FindControl("CheckBox1")).Checked = true;
            }
        }

        protected void f(object sender, CommandEventArgs e)
        {

            int id = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("StudentInfo.aspx?id=" + id);

        }
    }
}