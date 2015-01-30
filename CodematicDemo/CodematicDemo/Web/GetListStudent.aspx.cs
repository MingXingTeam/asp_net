using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ncu.jsj.Web
{
    public partial class GetListStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ncu.jsj.BLL.Student bll = new BLL.Student();
            GridView1.DataSource = bll.GetAllList();
            GridView1.DataBind();
        }
    }
}